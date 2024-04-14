using realProject.Data_models;
using realProject.My_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject
{
    public partial class Home : Form
    {
        private Person enteredUser;
        private List<Person> users = new List<Person>();
        List<Student> students = new List<Student>();
        private Login form4;
        private List<Course> courses = new List<Course>();
        List<MainMessagePanel> messages = new List<MainMessagePanel>();
        private List<FacultyProgram> facultyPrograms = new List<FacultyProgram>();
        List<Lecturer> lecturers = new List<Lecturer>();
        List<HeadDepartment> heads = new List<HeadDepartment>();
        private MenuPanel menuPanel;
        private AdminPage adminPage;
        private MainMessagesPage mainMessagePage;
        private MainPanel mainPanel = new MainPanel();
        private HomePage homePage = new HomePage();
        private CoursesPage coursesPage = new CoursesPage();
        private List<string> authorisedUsers = new List<string>();
        private bool isAdmin = false;
        System.Windows.Forms.Timer timer;

        public Home(Person user, Login form4)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Start();
            timer.Tick += Timer_Tick;
            InitializeComponent();
            
            //General initialization
            this.enteredUser = user;
            authorisedUsers.Add("Barak Goren");
            if (authorisedUsers.Contains(enteredUser.getName()))
            {
                isAdmin = true;
            }
            students = FileHandler.reloadStudents();
            lecturers = FileHandler.reloadLecturers();
            heads = FileHandler.loadHeads();
            courses = FileHandler.loadCourse();
            facultyPrograms = FileHandler.loadPrograms(courses);
            foreach (Course course in courses)
            {
                if(course.getCourseLecturer() == null)
                {
                    string courseLecId = null;
                    using(StreamReader reader = new StreamReader($"..\\..\\Files\\Courses\\{course.getName()}.txt"))
                    {
                        courseLecId = reader.ReadLine();
                    }
                    foreach(HeadDepartment head in heads)
                    {
                        if (head.getId().Equals(courseLecId))
                        {
                            course.setLecturer(head);
                        }
                    }
                }
            }
            homePage.watchLabel.Text = DateTime.Now.ToString("dd/MM/yy");
            homePage.dateLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            this.form4 = form4;
            

            // Form initialization
            homePage.displayUser(enteredUser);
            this.mainPanel.Controls.Add(this.homePage);
            this.enteredUser.setMessages(FileHandler.loadMessages(enteredUser.getId()));
            menuPanel = new MenuPanel();
            // if the user is not head department it wont show him the admin panel
            if(enteredUser.GetType() != typeof(HeadDepartment))
            {
                if (!isAdmin)
                {
                    menuPanel.getAdminButton().Hide();
                }
                
                
            }
            mainMessagePage = new MainMessagesPage();
            this.menuPanel.getPictureBox().Image = Image.FromFile(enteredUser.getPic());
            this.menuPanel.getNameLabel().Text = user.getName();
            this.Controls.Add(menuPanel);
            this.Controls.Add(mainPanel);
            if (enteredUser.GetType() == typeof(Student))
            {
                menuPanel.getTypeLabel().Text = "Student"; 
            } else if(enteredUser.GetType() == typeof(Lecturer))
            {
                this.menuPanel.getTypeLabel().Text = "Lecturer";
            } else if (enteredUser.GetType() == typeof(Tutor))
            {
                this.menuPanel.getTypeLabel().Text = "Tutor";
            } else
            {
                this.menuPanel.getTypeLabel().Text = "Head Department";
            }
            this.Width = menuPanel.Width + mainPanel.Width;
            this.Height = mainPanel.Height;


            //Initialize all messages components
            if (enteredUser.getMessages() != null)
            {
                for (int i = 0; i < enteredUser.getMessages().Count; i++)
                {
                    MainMessagePanel newMessage = new MainMessagePanel(enteredUser.getMessages()[i]);
                    newMessage.isImportant.Click += IsImportant_Click;
                    // those 3 lines are fitting the message panel display to the current flow panel
                    newMessage.messageTextBox.Width = mainMessagePage.allMessagesFlow.Width - 100;
                    newMessage.Width = mainMessagePage.allMessagesFlow.Width - 20;
                    newMessage.isImportant.Location = new Point(newMessage.messageFromLabel.Location.X + newMessage.messageTextBox.Width - 70, newMessage.isImportant.Location.Y);
                    // adding the message panel after fitting it
                    mainMessagePage.allMessagesFlow.Controls.Add(newMessage);

                    // add the message to saved messages if it starred
                    if (enteredUser.getMessages()[i].IsImportant)
                    {
                        newMessage.isImportant.Checked = true;
                        MainMessagePanel savedMessage = new MainMessagePanel(enteredUser.getMessages()[i]);
                        savedMessage.isImportant.Checked = true;
                        savedMessage.isImportant.Enabled = false;
                        savedMessage.messageTextBox.Width = mainMessagePage.savedMessagesFlow.Width - 100;
                        savedMessage.Width = mainMessagePage.savedMessagesFlow.Width - 20;
                        savedMessage.isImportant.Location = new Point(savedMessage.messageFromLabel.Location.X + savedMessage.messageTextBox.Width - 70, savedMessage.isImportant.Location.Y);
                        // adding the message panel after fitting it
                        mainMessagePage.savedMessagesFlow.Controls.Add(savedMessage);
                    }
                }
                foreach (realProject.Data_models.Message message in enteredUser.getMessages())
                {
                    if (message.IsImportant)
                    {
                        MainMessagePanel anotherMessage = new MainMessagePanel(message);
                        anotherMessage.isImportant.Enabled = false;
                        homePage.messagesFlow.Controls.Add(anotherMessage);
                        anotherMessage.Width = homePage.messagesFlow.Width - 30;
                        anotherMessage.isImportant.Location = new Point(anotherMessage.isImportant.Location.X - 65, anotherMessage.isImportant.Location.Y);
                        anotherMessage.isImportant.Checked = true;
                    }
                }
            }

            // Initialize Lecturer
            if(enteredUser.GetType() == typeof(Lecturer) || enteredUser.GetType() == typeof(Tutor))
            {
                Lecturer newLec = (Lecturer) enteredUser;
                homePage.programLabel.Text = "Subject:";
                homePage.programDisplay.Text = newLec.getSubject();

                //Initialization of Lecturer Course list & Students list
                List<Course> newLecCourses = new List<Course>();
                List<Student> newLecStudents = new List<Student>();
                foreach(Course course in courses)
                {
                    if (course.getCourseLecturer().Equals(newLec))
                    {
                        newLecCourses.Add(course);
                        foreach(Student student in course.getStudents())
                        {
                            newLecStudents.Add(student);
                        }
                    }
                }

                //Initialization of FlowLabels
                coursesPage.otherCoursesLabel.Text = "My Students";
                coursesPage.programCoursesLabel.Text = "My Courses";
                foreach(Course course in newLecCourses)
                {
                    CourseInfoPanel newCourse = new CourseInfoPanel(course);
                    coursesPage.programCoursesFlow.Controls.Add(newCourse);
                    newCourse.courseLabel.Location = new Point(newCourse.courseLabel.Location.X + 250, newCourse.courseLabel.Location.Y);
                    newCourse.Width = coursesPage.programCoursesFlow.Width - 50;
                    newCourse.rateBox.Hide();
                    newCourse.rateLabel.Hide();
                    newCourse.sendRate.Hide();

                }
                foreach(Student student in newLecStudents)
                {
                    InfoPanel newStudent = new InfoPanel();
                    newStudent.display(student);
                    newStudent.setWidth(350);
                    newStudent.getSendMessage().Hide();
                    newStudent.facultyTextBox.Text = student.getFaculty();
                    coursesPage.otherCoursesFlow.Controls.Add(newStudent);
                    
                }

            }
            //initialize Student
            if (enteredUser.GetType() == typeof(Student))
            {
                Student newStud = user as Student;

                foreach(Course course in newStud.getCourses())
                {
                    if (course.getStudents().Contains(newStud))
                    {
                        if (!newStud.getProgram().getCourses().Contains(course))
                        {
                            CourseInfoPanel newCourse = new CourseInfoPanel(course);
                            newCourse.Width = coursesPage.programCoursesFlow.Width - 27;
                            newCourse.courseLabel.Location = new Point(newCourse.Width / 2, newCourse.courseLabel.Location.Y);
                            newCourse.sendRate.Hide();
                            newCourse.rateLabel.Hide();
                            newCourse.rateBox.Hide();
                            coursesPage.otherCoursesFlow.Controls.Add(newCourse);
                        }   
                    }   
                } 
                foreach(FacultyProgram program in facultyPrograms)
                {
                    if (program.getName().Equals(newStud.getFaculty()))
                    {
                        newStud.setProgram(program);
                    }
                }
                // Course panel in homepage initialize
                foreach (Course course in newStud.getCourses())
                {
                    if (course.getStudents().Contains(user))
                    {
                        CourseInfoPanel newCourse = new CourseInfoPanel(course);
                        newCourse.sendRate.Click += SendRate_Click;
                        homePage.coursesFlow.Controls.Add(newCourse);
                        homePage.coursesFlow.Controls[homePage.coursesFlow.Controls.Count - 1].Width = homePage.coursesFlow.Width - 27;
                    }
                }

                Console.WriteLine(newStud.getProgram().getHeadDepartment());
                if (newStud.getProgram() != null)
                {
                    foreach (Course course in newStud.getProgram().getCourses())
                    {
                        CourseInfoPanel newCourse = new CourseInfoPanel(course);
                        newCourse.sendRate.Click += SendRate_Click;
                        homePage.coursesFlow.Controls.Add(newCourse);
                        homePage.coursesFlow.Controls[homePage.coursesFlow.Controls.Count - 1].Width = homePage.coursesFlow.Width - 27;
                    }
                    foreach (Course course in newStud.getProgram().getCourses())
                    {
                        CourseInfoPanel newCourse = new CourseInfoPanel(course);
                        newCourse.Width = coursesPage.programCoursesFlow.Width - 27;
                        newCourse.courseLabel.Location = new Point(newCourse.Width / 2, newCourse.courseLabel.Location.Y);
                        newCourse.sendRate.Hide();
                        newCourse.rateLabel.Hide();
                        newCourse.rateBox.Hide();
                        coursesPage.programCoursesFlow.Controls.Add(newCourse);
                    }
                }
                
            }


            //Initializing methods
            this.menuPanel.getAssesmentsButton().Click += messagesButton_Click;
            this.menuPanel.getHomeButton().Click += homeButton_Click;
            this.menuPanel.getCoursesButton().Click += coursesButton_Click;
            mainMessagePage.MessageBySearch.Click += button5_Click;
            menuPanel.getAdminButton().Click += adminButton_Clicked;
            menuPanel.getProfileButton().Click += settings_Click;

            //initializing users list (Polymorphizem)
            for(int i = 0;i < students.Count;i++)
            {
                users.Add(students[i]);
            }
            for(int i = 0; i < lecturers.Count; i++)
            {
                users.Add(lecturers[i]);
            }
            
        }

        private void coursesButton_Click(object sender, EventArgs e)
        {
            menuPanel.getAdminButton().BackColor = Color.AliceBlue;
            menuPanel.getCoursesButton().BackColor = Color.LightSteelBlue;
            menuPanel.getHomeButton().BackColor = Color.AliceBlue;
            menuPanel.getAssesmentsButton().BackColor = Color.AliceBlue;
            menuPanel.getProfileButton().BackColor = Color.AliceBlue;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(this.coursesPage);
        }

        private void SendRate_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CourseInfoPanel coursePanel = btn.Tag as CourseInfoPanel;
            Lecturer curLec = coursePanel.Course.getCourseLecturer();
            curLec.addRate(int.Parse(coursePanel.rateBox.Text));
            MessageBox.Show($"The current lecturere rate is: {curLec.getRate()}");
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            menuPanel.getAdminButton().BackColor = Color.AliceBlue;
            menuPanel.getCoursesButton().BackColor = Color.AliceBlue;
            menuPanel.getHomeButton().BackColor = Color.LightSteelBlue;
            menuPanel.getAssesmentsButton().BackColor = Color.AliceBlue;
            menuPanel.getProfileButton().BackColor = Color.AliceBlue;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(homePage);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            homePage.watchLabel.Text = DateTime.Now.ToString("dd/MM/yy");
            homePage.dateLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void IsImportant_Click(object sender, EventArgs e)
        {
            CheckBox isImportant = (CheckBox)sender;
            if (isImportant.Checked)
            {
                FileHandler.saveMessage(enteredUser.getId(), (Data_models.Message)isImportant.Tag, true);
            } else
            {
                FileHandler.saveMessage(enteredUser.getId(), (Data_models.Message)isImportant.Tag, false);
            }
            mainMessagePage.savedMessagesFlow.Controls.Clear();
            for(int i = 0; i < mainMessagePage.allMessagesFlow.Controls.Count; i++)
            {
                MainMessagePanel importanceCheck = (MainMessagePanel)mainMessagePage.allMessagesFlow.Controls[i];
                if (importanceCheck.isImportant.Checked)
                {
                    MainMessagePanel savedMessage = new MainMessagePanel(enteredUser.getMessages()[i]);
                    savedMessage.isImportant.Checked = true;
                    savedMessage.isImportant.Click += IsImportant_Click;
                    savedMessage.messageTextBox.Width = mainMessagePage.savedMessagesFlow.Width - 100;
                    savedMessage.Width = mainMessagePage.savedMessagesFlow.Width - 20;
                    savedMessage.isImportant.Enabled = false;
                    savedMessage.isImportant.Location = new Point(savedMessage.messageFromLabel.Location.X + savedMessage.messageTextBox.Width - 70, savedMessage.isImportant.Location.Y);
                    // adding the message panel after fitting it
                    mainMessagePage.savedMessagesFlow.Controls.Add(savedMessage);
                }
            }
        }

        private void messagesButton_Click(object sender, EventArgs e)
        {
            menuPanel.getAdminButton().BackColor = Color.AliceBlue;
            menuPanel.getCoursesButton().BackColor = Color.AliceBlue;
            menuPanel.getHomeButton().BackColor = Color.AliceBlue;
            menuPanel.getAssesmentsButton().BackColor = Color.LightSteelBlue;
            menuPanel.getProfileButton().BackColor = Color.AliceBlue;
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(mainMessagePage);
        }

        private void adminButton_Clicked(object sender, EventArgs e)
        {
            menuPanel.getAdminButton().BackColor = Color.LightSteelBlue;
            menuPanel.getCoursesButton().BackColor = Color.AliceBlue;
            menuPanel.getHomeButton().BackColor = Color.AliceBlue;
            menuPanel.getAssesmentsButton().BackColor = Color.AliceBlue;
            menuPanel.getProfileButton().BackColor = Color.AliceBlue;
            if (mainPanel.Controls.Count != 0)
            {
                if (mainPanel.Controls[0].GetType() != typeof(AdminPage)) { this.mainPanel.Controls.Clear(); }
            }
            adminPage = new AdminPage();
            adminPage.coursesDisplay.infoLabel.Text = "Courses";
            foreach (Course course in courses)
            {
                CourseInfoPanel newCourse = new CourseInfoPanel(course);
                adminPage.coursesDisplay.infoFlow.Controls.Add(newCourse);
            }
            try
            {
                adminPage.coursesDisplay.infoFlow.Width = adminPage.coursesDisplay.infoFlow.Controls[0].Width + 27;
            } catch(ArgumentOutOfRangeException) 
            {
                Console.WriteLine("No course info panels");
            }

            foreach(Course course in courses)
            {
                adminPage.adminTabControl.coursesList.Items.Add(course.getName());
            }
            adminPage.adminTabControl.createProgramButton.Click += CreateProgramButton_Click;


            for (int i = 0; i < lecturers.Count; i++)
            {
                adminPage.adminTabControl.courseComboBox.Items.Add(lecturers[i].getName());
            }
            foreach (HeadDepartment head in heads)
            {
                adminPage.adminTabControl.programHeadCheckBox.Items.Add(head.getName());
            }
            for (int i = 0; i < students.Count; i++)
            {
                adminPage.adminTabControl.courseCheckList.Items.Add(students[i].getName());
            }
            adminPage.adminTabControl.createCourseButton.Click += createCourse_Click;

            if (FileHandler.loadMessages(enteredUser.getId()) != null)
            {
                this.enteredUser.setMessages(FileHandler.loadMessages(enteredUser.getId()));

                foreach (realProject.Data_models.Message message in enteredUser.getMessages())
                {
                    MainMessagePanel newMessage = new MainMessagePanel(message);
                    newMessage.messageTextBox.Width = mainMessagePage.allMessagesFlow.Width - 100;
                    newMessage.Width = mainMessagePage.allMessagesFlow.Width - 20;
                    newMessage.isImportant.Location = new Point(newMessage.messageFromLabel.Location.X + newMessage.messageTextBox.Width - 70, newMessage.isImportant.Location.Y);
                    newMessage.isImportant.Hide();
                    adminPage.messagesDisplay.infoFlow.Controls.Add(newMessage);
                }
                adminPage.messagesDisplay.infoLabel.Text = $"{enteredUser.getMessages().Count} Messages";
            }
            else
            {
                adminPage.messagesDisplay.infoLabel.Text = "No messages";
            }

            // Initialize set new admin tab
            foreach(Lecturer lecturer in lecturers)
            {
                adminPage.adminTabControl.addHeadPanel.lecturersComboBox.Items.Add(lecturer.getName());
            }
            adminPage.adminTabControl.addHeadPanel.addButton.Click += setNewAdmin_Click;
            foreach(Control c in adminPage.adminTabControl.Controls)
            {
                Console.WriteLine(c.Name);
            }
            if (!isAdmin)
            {
               adminPage.adminTabControl.Controls.Remove(adminPage.adminTabControl.setNewAdmin);
            }
            this.mainPanel.Controls.Add(adminPage);
        }

        private void setNewAdmin_Click(object sender, EventArgs e)
        {
            Lecturer chosenLec = null;
            string lecName = adminPage.adminTabControl.addHeadPanel.lecturersComboBox.Text;
            string inputPassword = adminPage.adminTabControl.addHeadPanel.passwordTextBox.Text;

            foreach(Lecturer lec in lecturers)
            {
                if (lec.getName().Equals(lecName))
                {
                    chosenLec = lec;
                }
            }
            if (inputPassword.Equals(enteredUser.getPassword()))
            {
                if(chosenLec != null)
                {
                    Console.WriteLine("You chose: " + chosenLec.getName() + " that teaches "+ chosenLec.getSubject());
                    FileHandler.setNewAdmin(chosenLec);
                } else
                {
                    Console.WriteLine("No such lecturer");
                }
            } else
            {
                Console.WriteLine("Wrong password!");
            }
        }

        private void CreateProgramButton_Click(object sender, EventArgs e)
        {
            string programName = adminPage.adminTabControl.programNameTextBox.Text;
            String programHead = null;
            List<string> programCoursesNames = new List<string>();
            List<Course> programCourses = new List<Course>();
            for(int i = 0; i < adminPage.adminTabControl.coursesList.CheckedItems.Count; i++)
            {
                programCoursesNames.Add(adminPage.adminTabControl.coursesList.CheckedItems[i].ToString());
            }
            foreach(string courseName in programCoursesNames)
            {
                foreach(Course course in this.courses)
                {
                    if (course.getName().Equals(courseName))
                    {
                        programCourses.Add(course);
                    }
                }
            }
            string headName = adminPage.adminTabControl.programHeadCheckBox.Text;
            foreach(HeadDepartment h in heads)
            {
                if (h.getName().Equals(headName))
                {
                    programHead = h.getId();
                }
            }
            FacultyProgram newProgram = new FacultyProgram(programName, programHead, programCourses);
            FileHandler.newProgram(newProgram);
            MessageBox.Show("Program " + newProgram.getName() + " has created!");
        }

        private void settings_Click(object sender, EventArgs e)
        {
            menuPanel.getAdminButton().BackColor = Color.AliceBlue;
            menuPanel.getCoursesButton().BackColor = Color.AliceBlue;
            menuPanel.getHomeButton().BackColor = Color.AliceBlue;
            menuPanel.getAssesmentsButton().BackColor = Color.AliceBlue;
            menuPanel.getProfileButton().BackColor = Color.LightSteelBlue;
            this.mainPanel.Controls.Clear();
            UserProfile enteringProfile = new UserProfile(enteredUser);
            enteringProfile.displayProfile(enteredUser);
            this.mainPanel.Controls.Add(enteringProfile);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Users form1 = new Users(this.enteredUser, users);
            form1.Show();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            form4.Show();
        }

        private void createCourse_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < adminPage.adminTabControl.courseCheckList.CheckedItems.Count;i++)
            {
                for(int j = 0; j < this.students.Count; j++)
                {
                    if (adminPage.adminTabControl.courseCheckList.CheckedItems[i].Equals(this.students[j].getName()))
                    {
                        students.Add(this.students[j]);
                    }
                }
            }
            string lecturerName = adminPage.adminTabControl.courseComboBox.SelectedItem.ToString();
            Lecturer newLecturer = null;
            for(int i = 0; i < this.lecturers.Count; i++)
            {
                if (lecturerName.Equals(lecturers[i].getName()))
                {
                    newLecturer = lecturers[i];
                }
            }
            Course newCourse = new Course(adminPage.adminTabControl.courseNameTextBox.Text, students, newLecturer);
            FileHandler.newCourse(newCourse);
            courses.Add(newCourse);
            adminPage.coursesDisplay.infoFlow.Controls.Add(new CourseInfoPanel(newCourse));
            
        }

    }
}

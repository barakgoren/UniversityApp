using realProject.Data_models;
using realProject.My_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject
{
    public partial class Login : Form
    {
        private List<Person> users = new List<Person>();
        
        LoginPanel loginPanel;
        RegisterPanel1 registerPanel1;
        StudentRegistration registerStudent;
        LecturerRegistration registerLecturer;
        Home nextForm;
        string filePath;
        List<Student> students = new List<Student>();
        List<Lecturer> lecturers = new List<Lecturer>();
        List<HeadDepartment> heads = new List<HeadDepartment>();

        public Login()
        {
            InitializeComponent();
            loginPanel = new LoginPanel();
            registerPanel1 = new RegisterPanel1();
            registerStudent = new StudentRegistration();
            registerLecturer = new LecturerRegistration();
            
            this.Controls.Add(loginPanel);
            
            students = FileHandler.reloadStudents();
            lecturers = FileHandler.reloadLecturers();
            heads = FileHandler.loadHeads();

            foreach(Student student in students)
            {
                foreach(Course course in student.getCourses())
                {
                    if (course.getCourseLecturer() == null)
                    {
                        string courseLecId = null;
                        using (StreamReader reader = new StreamReader($"..\\..\\Files\\Courses\\{course.getName()}.txt"))
                        {
                            courseLecId = reader.ReadLine();
                        }
                        foreach (HeadDepartment head in heads)
                        {
                            if (head.getId().Equals(courseLecId))
                            {
                                course.setLecturer(head);
                            }
                        }
                    }
                }
            }
            users.AddRange(students);
            users.AddRange(lecturers);
            users.AddRange(heads);

            loginPanel.getLoginButton().Click += loginButton_Click;
            loginPanel.getLoginButton().MouseEnter += loginChangeColor_Hover;
            loginPanel.getLoginButton().MouseLeave += loginChangeColor_Leave;
            loginPanel.getShowCheckBox().Click += showPassword_Check;
            loginPanel.getPasswordTextBox().KeyPress += PasswordTextBox_KeyPress;
            loginPanel.getRegisterLink().LinkClicked += linkLabel1_LinkClicked;

            registerPanel1.getStudentButton().Click += studentRegister_Clicked;
            registerPanel1.getBackButton().Click += backButton_Clicked;
            registerPanel1.getLecturerButton().Click += studentRegister_Clicked;

            registerStudent.getUploadPanel().getUploadButton().Click += button1_Click;
            registerStudent.getBackButton().Click += backButton_StudentClicked;
            registerStudent.getRegisterButton().Click += registerButton_Clicked;

            registerLecturer.getBackButton().Click += backButton_Clicked;
            registerLecturer.getRegisterButton().Click += lecRegister_Click;
            registerLecturer.getUploadPanel().getUploadButton().Click += button1_Click;
            
        }

        private void lecRegister_Click(object sender, EventArgs e)
        {
            List<string> lecAtt = new List<string>();
            lecAtt = registerLecturer.getAllTextBoxs();
            bool hasEmpty = false;
            Lecturer newLec;
            for (int i = 0; i < lecAtt.Count; i++)
            {
                if (lecAtt[i].Equals(""))
                {
                    hasEmpty = true;
                }
            }
            if (!hasEmpty)
            {
                if (!accountExsist(users, lecAtt[0]))
                {
                    if(this.filePath == null)
                    {
                        this.filePath = "..\\..\\Resources\\noprofile.jpg";
                    }
                    string picPath = this.filePath;
                    string fileName = Path.GetFileName(picPath);
                    File.Copy(picPath, $"..\\..\\Files\\Profile Pictures\\{fileName}", true);
                    picPath = $"..\\..\\Files\\Profile Pictures\\{fileName}";
                    newLec = new Lecturer(lecAtt[0], lecturers.Count, lecAtt[1], lecAtt[2], lecAtt[3], picPath, registerLecturer.getAgeValue(), lecAtt[4], lecAtt[5]);
                    registerUser(newLec);
                    users.Add(newLec);
                    MessageBox.Show("Registered Successfully!");
                    this.Controls.Clear();
                    this.Controls.Add(loginPanel);
                }
                else
                {
                    MessageBox.Show("User already exist!");
                }

            }
            else
            {
                MessageBox.Show("Must fill all fields");
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < users.Count; i++)
            {
                if (users[i].getName().Equals(loginPanel.getNameTextBox().Text))
                {
                    if (users[i].getPassword().Equals(loginPanel.getPasswordTextBox().Text))
                    {
                        MessageBox.Show("Login Successfuly");
                        nextForm = new Home(users[i],this);
                        this.Hide();
                        nextForm.Show();
                        break;
                    } else 
                    {
                        MessageBox.Show("Wrong Password!");
                        break;
                    }
                }
                if(i == users.Count-1)
                {
                    MessageBox.Show("User not found");
                }
            }
        }
        private void showPassword_Check(object sender, EventArgs e)
        {
            if (loginPanel.getShowCheckBox().Checked)
            {
                loginPanel.getPasswordTextBox().UseSystemPasswordChar = false;
            } else
            {
                loginPanel.getPasswordTextBox().UseSystemPasswordChar= true;
            }
        }
        private void loginChangeColor_Hover(object sender, EventArgs e)
        {
            loginPanel.getLoginButton().BackColor = Color.FromArgb(255,255,255);
            loginPanel.getLoginButton().ForeColor = Color.FromArgb(7, 18, 42);
        }
        private void loginChangeColor_Leave(object sender, EventArgs e)
        {
            loginPanel.getLoginButton().BackColor= Color.FromArgb(7, 18, 42);
            loginPanel.getLoginButton().ForeColor = Color.White;
        }
        private void PasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
            {
                loginButton_Click(sender, e);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(registerPanel1);

        }
        private void studentRegister_Clicked(object sender, EventArgs e)
        {
            this.Controls.Clear();
            if(sender.GetType() == typeof(Button))
            {
                Button btn =  (Button)sender;
                
                if (btn.Text.Contains("lecturer"))
                {
                    this.Controls.Add(registerLecturer);
                    
                } else
                {
                    this.Controls.Add(registerStudent);
                }
            }
            this.Width += 10;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.png; *.jpg; *.jpeg";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.filePath = openFileDialog.FileName;
                    registerLecturer.getUploadPanel().getPictureBox().Image = Image.FromFile(filePath);
                    registerStudent.getUploadPanel().getPictureBox().Image = Image.FromFile(filePath);
                    
                }
            }
        }
        private void backButton_StudentClicked(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(registerPanel1);
        }
        private void backButton_Clicked(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(loginPanel);
        }
        private void registerButton_Clicked(object sender, EventArgs e)
        {
            List<string> userAtt = new List<string>();
            Student newStudentUser;
            userAtt = registerStudent.getAllTextBoxs();
            int generatedStudentId = students.Count;
            int points = 0;
            bool hasEmpty = false;
            for(int i = 0; i < userAtt.Count; i++)
            {
                if (userAtt[i].Equals(""))
                {
                    hasEmpty = true;
                }
            }
            if (!hasEmpty)
            {
                if(!accountExsist(users, userAtt[0]))
                {
                    if (this.filePath == null)
                    {
                        this.filePath = "..\\..\\Resources\\noprofile.jpg";
                    }
                    string picPath = this.filePath;
                    string fileName = Path.GetFileName(picPath);
                    File.Copy(picPath, $"..\\..\\Files\\Profile Pictures\\{fileName}", true);
                    picPath = $"..\\..\\Files\\Profile Pictures\\{fileName}";
                    newStudentUser = new Student(userAtt[0], generatedStudentId, userAtt[1], userAtt[2], userAtt[3], registerStudent.getAgeValue(), picPath, userAtt[5], points, userAtt[6]);
                    registerUser(newStudentUser);
                    MessageBox.Show("Registered Successfully!");
                    this.Controls.Clear();
                    this.Controls.Add(loginPanel);
                }
                else
                {
                    MessageBox.Show("User already exist!");
                }
                
            }
            else
            {
                MessageBox.Show("Must fill all fields");
            }

        }
        public void registerUser(Person person)
        {
            if (person.GetType() == typeof(Student))
            {
                Student student = (Student)person;
                String filePath = "..\\..\\Files\\Students.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(student.ToString());
                    writer.Close();
                }
            } else
            {
                Lecturer lecturer = (Lecturer)person;
                String filePath = "..\\..\\Files\\Lecturers.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(lecturer.ToString());
                    writer.Close();
                }
            }
        }
        public bool accountExsist(List<Person> person, string personId)
        {
            for(int i = 0; i < person.Count; i++)
            {
                if (person[i].getId() == personId)
                {
                    return true;
                }
            }
            return false;
        }
        private void Form4_ControlAdded(object sender, ControlEventArgs e)
        {
            this.Size = this.Controls[this.Controls.Count - 1].Size;
            this.Height += 40;
        }
    }
}

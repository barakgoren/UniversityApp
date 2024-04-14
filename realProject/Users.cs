using realProject.Data_models;
using realProject.My_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace realProject
{
    public partial class Users : Form
    {
        List<Person> persons = new List<Person>();
        Person enteredUser;
        List<InfoPanel> infoPanels = new List<InfoPanel>();
        SortingButton sortingButton = new SortingButton();
        SearchForUser searchUser = new SearchForUser();
        SearchPanel searchPanel = new SearchPanel();
        SendMessagePanel sendMessage;
        FlowLayoutPanel flowLayoutPanel1;
        public Users(Person enteredUser, List<Person> users)
        {
            /*persons.Add(new Student(143, "Barak
             * ", 24, "Software Engineering"));
            persons.Add(new Lecturer(23, "Lev", 54, "Mathematics"));
            persons.Add(new Student(58, "Tslil", 21, "Asia"));
            persons.Add(new Lecturer(189, "Michal", 40, "Korean Language"));
            persons.Add(new Student(100, "Tamir", 25, "Computer Science"));
            persons.Add(new Lecturer(44, "Joshua", 60, "Physics"));
            persons.Add(new Student(89, "Tom", 26, "Physics"));
            persons.Add(new Lecturer(170, "Alon", 45, "Architecture"));*/

            
            InitializeComponent();
            this.enteredUser = enteredUser;
            this.persons = users;
            Console.WriteLine("All Users");
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i]);
            }
            this.Controls.Add(searchPanel);
            this.Width = searchPanel.Width + 25;
            this.Height = searchPanel.Height + 48;
            flowLayoutPanel1 = searchPanel.getFlowLayoutPanel();
            sortingButton = searchPanel.getSortingButton();
            searchUser = searchPanel.getSearchBar();
            infoPanels = searchPanel.getInfoPanels();

            for (int i = 0; i < persons.Count; i++)
            {
                infoPanels.Add(new InfoPanel());
                infoPanels[i].display(persons[i]);
                infoPanels[i].getSendMessage().Click += sendMessage_Click;
                flowLayoutPanel1.Controls.Add(infoPanels[i]);
            }
            searchUser.getSearch().TextChanged += searchBox_TextChanged;
            sortingButton.getSortByAge().Click += sortByAge_Click;
            sortingButton.getSortById().Click += sortById_Click;
            sortingButton.getSortByType().Click += sortByType_Click;
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(searchPanel);
            this.Width = searchPanel.Width;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            infoPanels.Clear();
            List<Person> filteredPersons = new List<Person>();
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i].getName().Contains(searchUser.getSearch().Text))
                {
                    filteredPersons.Add(persons[i]);
                }
            }
            for (int i = 0; i < filteredPersons.Count; i++)
            {
                infoPanels.Add(new InfoPanel());
                infoPanels[i].display(filteredPersons[i]);
                infoPanels[i].getSendMessage().Click += sendMessage_Click;
                flowLayoutPanel1.Controls.Add(infoPanels[i]);
            }

        }
        private void sortById_Click(object sender, EventArgs e)
        {
            int n = persons.Count;
            Person temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < (n - i); j++)
                {
                    if (int.Parse(persons[j - 1].getId()) > int.Parse(persons[j].getId()))
                    {
                        temp = persons[j - 1];
                        persons[j - 1] = persons[j];
                        persons[j] = temp;
                    }
                }
            }

            for (int i = 0; i < persons.Count; i++)
            {
                infoPanels[i].display(persons[i]);

            }

        }
        private void sortByAge_Click(object sender, EventArgs e)
        {
            int n = persons.Count;
            Person temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < (n - i); j++)
                {
                    if (persons[j - 1].getAge() > persons[j].getAge())
                    {
                        temp = persons[j - 1];
                        persons[j - 1] = persons[j];
                        persons[j] = temp;
                    }
                }
            }

            for (int i = 0; i < persons.Count; i++)
            {
                infoPanels[i].display(persons[i]);

            }
        }
        private void sortByType_Click(object sender, EventArgs e)
        {
            Person[] pArr = new Person[persons.Count];
            if (persons[0].GetType() == typeof(Student))
            {
                int index = 0;
                for (int i = 0; i < pArr.Length; i++)
                {
                    if (persons[i].GetType() == typeof(Lecturer))
                    {
                        pArr[index++] = persons[i];
                    }
                }
                index = pArr.Length - 1;
                for (int i = 0; i < pArr.Length; i++)
                {
                    if (persons[i].GetType() == typeof(Student))
                    {
                        pArr[index--] = persons[i];
                    }
                }
                for (int i = 0; i < pArr.Length; i++)
                {
                    persons[i] = pArr[i];
                    infoPanels[i].display(persons[i]);
                }
            } else
            if (persons[0].GetType() == typeof(Lecturer))
            {
                int index = 0;
                for (int i = 0; i < pArr.Length; i++)
                {
                    if (persons[i].GetType() == typeof(Student))
                    {
                        pArr[index++] = persons[i];
                    }
                }
                index = pArr.Length - 1;
                for (int i = 0; i < pArr.Length; i++)
                {
                    if (persons[i].GetType() == typeof(Lecturer))
                    {
                        pArr[index--] = persons[i];
                    }
                }
                for (int i = 0; i < pArr.Length; i++)
                {
                    persons[i] = pArr[i];
                    infoPanels[i].display(persons[i]);
                }
            }
        }
        private void sendMessage_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Button btn = (Button)sender;
            Person destination = null;
            for(int i = 0; i < persons.Count; i++)
            {
                if (persons[i].getId().Equals(btn.Tag.ToString()))
                {
                    destination = persons[i];
                }
            }
            if(destination != null)
            {
                sendMessage = new SendMessagePanel(destination);
            } 
            this.Controls.Add(this.sendMessage);
            this.Width = sendMessage.Width;
            sendMessage.getBackButton().Click += backButton_Click;
            sendMessage.getSendButton().Click += send_Click;
        }

        private void send_Click(object sender, EventArgs e)
        {
            int messagesAmount = 0;
            if (FileHandler.loadMessages(sendMessage.getDestination().getId()) != null)
            {
                messagesAmount = FileHandler.loadMessages(sendMessage.getDestination().getId()).Count;
            }   
            realProject.Data_models.Message message = new Data_models.Message(messagesAmount.ToString(), enteredUser.getName(), sendMessage.getContent().Text, DateTime.Now.ToString(), false);
            FileHandler.sendMessage(sendMessage.getDestination().getId(), message);
            for(int i = 0; i < persons.Count;i++)
            {
                if (persons[i].getId().Equals(sendMessage.getDestination().getId()))
                {
                    persons[i].addMessage(message);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(searchPanel);
            this.Width = searchPanel.Width;
            MessageBox.Show("Message Sent!");
        }

        public List<Person> getPersons() { return persons; }
        public List<InfoPanel> getInfoPanels() { return infoPanels; }

        public void registerPerson(Person person)
        {
            this.persons.Add(person);
            infoPanels.Add(new InfoPanel());
            infoPanels[infoPanels.Count-1].display(persons[infoPanels.Count - 1]);
            flowLayoutPanel1.Controls.Add(infoPanels[infoPanels.Count-1]);

            //Add student to students file
            if(person.GetType() == typeof(Student))
            {
                Student student = (Student)person;
                String filePath = "..\\..\\Files\\Students.txt";
                using(StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(student.ToString());
                }
            }
        }
        public void initializeUsers(List<Person> users)
        {
            for(int i = 0; i < users.Count; i++)
            {
                this.persons.Add(users[i]);
            }
        }
    }
}

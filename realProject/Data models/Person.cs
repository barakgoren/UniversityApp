using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Person
    {
        private string id;
        private string name;
        private string email;
        private string password;
        private int age;
        private string phoneNumber;
        private List<Message> messages;
        private string picPath;

        public Person(string id, string name, string email, int age, string password, string phoneNumber, string picPath)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.age = age;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.picPath = picPath;
        }

        public string getId() { return this.id; }
        public string getName() { return this.name; }
        public int getAge() { return this.age; }
        public string getPassword() { return this.password; }
        public string getEmail() { return this.email; }
        public string getPhone() { return this.phoneNumber; }
        public string getPic() { return this.picPath; }
        public void setMessages(List<Message> messages)
        {
            this.messages = messages;
        }
        public List<Message> getMessages() {  return this.messages; }
        public void addMessage(Message message)
        {
            if(messages == null)
            {
                messages = new List<Message>();
            }
            this.messages.Add(message);
        }

    }



}

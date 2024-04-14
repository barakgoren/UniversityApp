using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Lecturer:Person
    {
        private int lecturerId;
        private List<Course> courses;
        private string subject;
        private double rate;
        public List<Student> students {  get; set; }
        

        public Lecturer(string id, int lecturerId, string name, string email, string phoneNumber, string picPath, int age, string subject, string password):
            base(id, name, email, age, password, phoneNumber, picPath)
        {
            this.subject = subject;
            this.lecturerId = lecturerId;
        }
        public double getRate() { return rate; }
        public void setRate(double rate) { this.rate = rate;}
        public void addRate(int num) 
        {
            if(this.rate == 0)
            {
                this.rate = num;
            } else
            {
                this.rate = (this.rate + num) / 2;
            }
            FileHandler.updateLecRate(this);
        }
        public string getSubject() { return subject; }
        public override string ToString()
        {
            return $"{this.getId()}^{this.lecturerId}^{this.getName()}^{this.getEmail()}^{this.getPhone()}^{this.getPic()}^{this.getAge()}^{this.subject}^{this.rate}^{this.getPassword()}";
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType() == typeof(Lecturer))
            {
                Lecturer lecturer = (Lecturer)obj;
                if (lecturer.getId() == this.getId())
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }
        public void setCourses(List<Course> courses) { this.courses = courses;}
        public List<Course> getCourses() { return courses;}
        public void setStudents(List<Student> students) { this.students = students;}
        public int getLecId()
        {
            return lecturerId;
        }
        
    }
}

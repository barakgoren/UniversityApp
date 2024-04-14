using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Student:Person
    {
        private string facultyProgram;
        private int studentId;
        private int points;
        private List<Course> courses = new List<Course>();
        private FacultyProgram program;

        public Student(string id, int studentId, string name, string email, string phoneNumber, int age, string picPath, string facultyProgram, int points, string password) :
            base(id, name, email, age, password, phoneNumber, picPath)
        {
            this.studentId = studentId;
            this.facultyProgram = facultyProgram;
            this.points = points;
        }

        public string getFaculty() {  return this.facultyProgram; }
        public List<Course> getCourses() { return this.courses; }
        public void setCourses(List<Course> courses)
        {
            this.courses = courses;
        }
        public override string ToString()
        {
            return $"{this.getId()},{this.studentId},{this.getName()},{this.getEmail()},{this.getPhone()},{this.getAge()},{this.getPic()},{this.facultyProgram},{this.points},{this.getPassword()}";
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Student))
            {
                Student student = (Student)obj;
                if (student.getName() == this.getName())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void setProgram(FacultyProgram program)
        {
            this.program = program;
        }
        public FacultyProgram getProgram() { return this.program; }
        public void addCourse(Course course)
        {
            if(this.courses != null)
            {
                if (!this.courses.Contains(course))
                {
                    this.courses.Add(course);
                }
                
            }
            
        }
    }
}

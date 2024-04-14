using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class FacultyProgram
    {
        private string name;
        private string head;
        private List<Course> courses;
        private List<Student> students;

        public FacultyProgram(string name, String head, List<Course> courses)
        {
            this.name = name;
            this.courses = courses;
            this.head = head;
        }

        public string getName() { return this.name; }
        public List<Course> getCourses() {  return this.courses; }
        public List<Student> getStudents() {  return this.students; }
        public string getHeadDepartment() { return this.head; }
        public void setStudents(List<Student> students) { this.students = students;}

    }
}

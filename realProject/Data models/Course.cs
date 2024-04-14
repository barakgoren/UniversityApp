using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Course
    {
        private string name;
        private List<Student> students;
        private Lecturer courseLecturer;

        public Course(string name, List<Student> students, Lecturer courseLecturer)
        {
            this.name = name;
            this.students = students;
            this.courseLecturer = courseLecturer;
        }

        public string getName() { return name; }
        public Lecturer getCourseLecturer() {  return courseLecturer; }
        
        public List<Student> getStudents() {  return students; }
        public void addStudent(Student student) { this.students.Add(student); }
        public void setLecturer(Lecturer courseLecturer) { this.courseLecturer= courseLecturer; }
    }
}

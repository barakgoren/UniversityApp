using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class Tutor:Student
    {
        private List<Course> courses;

        public Tutor(string id, int studentId, string name, string email, string phoneNumber, int age, string picPath, string facultyProgram, int points, string password, List<Course> courses)
                    :base(id, studentId, name, email, phoneNumber, age, picPath, facultyProgram, points, password)
        {
            this.courses = courses;
        }
    }
}

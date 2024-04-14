using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace realProject.Data_models
{
    public class HeadDepartment:Lecturer
    {
        private List<FacultyProgram> programsInCharge;
        private List<Lecturer> staff;
        private List<Student> students;

        public HeadDepartment(string id, int lecturerId, string name, string email, string phoneNumber, string picPath, int age, string subject, int rate, string password,
                              List<FacultyProgram> programsInCharge, List<Lecturer> staff, List<Student> students)
                              :base(id, lecturerId, name, email, phoneNumber, picPath, age, subject, password)
        {
            this.programsInCharge = programsInCharge;
            this.staff = staff;
            this.students = students;
        }
        public HeadDepartment(Lecturer lecturer, List<FacultyProgram> programsInCharge, List<Lecturer> staff, List<Student> students)
                              : base(lecturer.getId(), lecturer.getLecId(), lecturer.getName(), lecturer.getEmail(), lecturer.getPhone(), lecturer.getPic(), lecturer.getAge(), lecturer.getSubject(), lecturer.getPassword())
        {
            this.programsInCharge = programsInCharge;
            this.staff = staff;
            this.students = students;
        }
        public List<FacultyProgram> getPrograms() { return programsInCharge; }
        public override string ToString()
        {
            return this.getId()+"^"+this.getLecId() + "^"+ this.getName() + "^" + this.getEmail() + "^"+ this.getPhone() + "^" + this.getPic() + "^"+ this.getAge() + "^" + this.getSubject() + "^" + this.getRate() + "^" + this.getPassword();
        }
    }
}

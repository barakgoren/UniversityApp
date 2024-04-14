using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace realProject.Data_models
{
    public class FileHandler
    {
        public static List<Student> reloadStudents()
        {
            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader("C:\\Users\\barak\\OneDrive\\שולחן העבודה\\realProject\\realProject\\Files\\Students.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] studentAtt = line.Split(',');
                    students.Add(new Student(studentAtt[0],
                                             int.Parse(studentAtt[1]),
                                             studentAtt[2],
                                             studentAtt[3],
                                             studentAtt[4],
                                             int.Parse(studentAtt[5]),
                                             studentAtt[6],
                                             studentAtt[7],
                                             int.Parse(studentAtt[8]),
                                             studentAtt[9]));
                }
                List<Course> courses = loadCourse();
                List<FacultyProgram> programs = loadPrograms(courses);
                foreach(Student student in students)
                {
                    foreach(FacultyProgram program in programs)
                    {
                        if (student.getFaculty().Equals(program.getName()))
                        {
                            student.setProgram(program);
                        }
                    }
                }
                foreach(Student student in students)
                {
                    foreach(Course course in courses)
                    {
                        if (course.getStudents().Contains(student))
                        {
                            if(student.getProgram() != null)
                            {
                                if (!student.getProgram().getCourses().Contains(course))
                                {
                                    student.addCourse(course);
                                }
                            } else
                            {
                                student.addCourse(course);
                            }
                            
                        }
                    }
                }
            }
            return students;
        }
        public static List<Lecturer> reloadLecturers()
        {
            string[] currentLecturer = new string[5];
            List<Lecturer> lecturers = new List<Lecturer>();
            using (StreamReader reader = new StreamReader("..\\..\\Files\\Lecturers.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] lecturersAtt = line.Split('^');
                    lecturers.Add(new Lecturer(lecturersAtt[0], int.Parse(lecturersAtt[1]), lecturersAtt[2], lecturersAtt[3], lecturersAtt[4], lecturersAtt[5], int.Parse(lecturersAtt[6]), lecturersAtt[7], lecturersAtt[9]));
                    lecturers[lecturers.Count - 1].setRate(double.Parse(lecturersAtt[8]));
                }
            }
            return lecturers;
        }
        public static List<HeadDepartment> loadHeads()
        {
            List<HeadDepartment> heads = new List<HeadDepartment>();
            List<FacultyProgram> headPrograms = new List<FacultyProgram>();
            List<Lecturer> headStaff = new List<Lecturer>();
            List<Student> headStudents = new List<Student>();
            using (StreamReader reader = new StreamReader("..\\..\\Files\\HeadDepartment.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] headAtts = line.Split('^');
                    String headProgramId = headAtts[0];
                    List<FacultyProgram> allPrograms = loadPrograms(loadCourse());

                    foreach(FacultyProgram program in allPrograms)
                    {
                        if (program.getHeadDepartment().Equals(headProgramId))
                        {
                            headPrograms.Add(program);
                        }
                    }
                    foreach(FacultyProgram program in headPrograms)
                    {
                        foreach(Course course in program.getCourses())
                        {
                            headStaff.Add(course.getCourseLecturer());
                            headStudents.AddRange(course.getStudents());
                        }
                    }
                    
                    heads.Add(new HeadDepartment(headAtts[0], int.Parse(headAtts[1]), headAtts[2], headAtts[3], headAtts[4], headAtts[5], int.Parse(headAtts[6]), headAtts[7], int.Parse(headAtts[8]), headAtts[9], headPrograms, headStaff, headStudents));
                    headPrograms.Clear();
                    headStaff.Clear();
                    headStudents.Clear();
                }
            }
            return heads;
        }
        public static List<Message> loadMessages(string id)
        {
            List<Message> messages = new List<Message>();
            try
            {
                using (StreamReader reader = new StreamReader($"..\\..\\Files\\Messages\\{id}_messages.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] msgAtt = line.Split('^');
                        bool IsImportant;
                        if (msgAtt[4].Equals("False"))
                        {
                            IsImportant = false;
                        } else
                        {
                            IsImportant = true;
                        }
                        messages.Add(new Message(msgAtt[0],msgAtt[1], msgAtt[2], msgAtt[3], IsImportant));
                    }
                }
            }catch(FileNotFoundException e)
            {
                messages = null;
            }
            

            return messages;
        }
        public static void saveMessage(string userId, Message message, bool doOrUndo)
        {
            string[] userMessages = System.IO.File.ReadAllLines($"..\\..\\Files\\Messages\\{userId}_messages.txt");
            string[] messageAtt;

            for (int i = 0; i < userMessages.Length; i++)
            {
                messageAtt = userMessages[i].Split('^');
                if (messageAtt[0].Equals(message.MessageId))
                {
                    messageAtt[messageAtt.Length - 1] = doOrUndo.ToString();
                    userMessages[i] = $"{messageAtt[0]}^{messageAtt[1]}^{messageAtt[2]}^{messageAtt[3]}^{messageAtt[4]}";
                    break;
                }
            }
            using(StreamWriter writer = new StreamWriter($"..\\..\\Files\\Messages\\{userId}_messages.txt"))
            {
                foreach(string line in userMessages)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
            }

        }
        public static void sendMessage(string id, Message message)
        {
            String filePath = $"..\\..\\Files\\Messages\\{id}_messages.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(message.ToString());
                writer.Close();
            }

        }
        public static List<Course> loadCourse() 
        {
            List<Course> courses = new List<Course>();
            string directoryPath = "..\\..\\Files\\Courses";
            
            if (Directory.Exists(directoryPath))
            {
                // Get the list of file paths in the directory
                string[] filePaths = Directory.GetFiles(directoryPath);

                // Loop through each file path
                foreach (string filePath in filePaths)
                {
                    
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string lecID = reader.ReadLine();
                        Lecturer courseLecturer = null;
                        foreach(Lecturer lec in reloadLecturers())
                        {
                            if (lec.getId().Equals(lecID))
                            {
                                courseLecturer = lec;
                            }
                        }

                        string courseName = Path.GetFileNameWithoutExtension(filePath);
                        List<Student> students = new List<Student>();
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] studentAtt = line.Split(',');
                            students.Add(new Student(studentAtt[0],
                                                        int.Parse(studentAtt[1]),
                                                        studentAtt[2],
                                                        studentAtt[3],
                                                        studentAtt[4],
                                                        int.Parse(studentAtt[5]),
                                                        studentAtt[6],
                                                        studentAtt[7],
                                                        int.Parse(studentAtt[8]),
                                                        studentAtt[9]));

                        }
                        courses.Add(new Course(courseName, students, courseLecturer));
                        
                        
                        reader.Close();
                    }
                    
                }
            }

            return courses;
        }
        public static void newCourse(Course course)
        {
            String filePath = $"..\\..\\Files\\Courses\\{course.getName()}.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                
                writer.WriteLine(course.getCourseLecturer().getId());
                for(int i = 0; i < course.getStudents().Count; i++)
                {
                    writer.WriteLine(course.getStudents()[i].ToString());
                }
                writer.Close();

            }
        }
        public static void updateLecRate(Lecturer lecWithNewRate)
        {
            List<Lecturer> curLecturers = reloadLecturers();
            for(int i = 0; i < curLecturers.Count; i++)
            {
                if (curLecturers[i].Equals(lecWithNewRate))
                {
                    curLecturers[i] = lecWithNewRate;
                }
            }
            using(StreamWriter writer = new StreamWriter("..\\..\\Files\\Lecturers.txt", false))
            {
                foreach(Lecturer lec in curLecturers)
                {
                    writer.WriteLine(lec.ToString());
                }
                writer.Close();
            }
        }
        public static void newProgram(FacultyProgram newProgram)
        {
            using(StreamWriter writer = new StreamWriter($"..\\..\\Files\\Programs\\{newProgram.getName()}.txt"))
            {
                writer.WriteLine(newProgram.getHeadDepartment());
                foreach(Course course in newProgram.getCourses())
                {
                    writer.WriteLine(course.getName());
                }
            }
        }
        public static List<FacultyProgram> loadPrograms(List<Course> allCourses)
        {
            List<FacultyProgram> programs = new List<FacultyProgram>();
            string directoryPath = "..\\..\\Files\\Programs";
            if (Directory.Exists(directoryPath))
            {
                // Get the list of file paths in the directory
                string[] filePaths = Directory.GetFiles(directoryPath);

                // Loop through each file path
                foreach (string filePath in filePaths)
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        List<Course> programCourses = new List<Course>();
                        string programName = Path.GetFileNameWithoutExtension(filePath);
                        string programHead = reader.ReadLine();
                        while (!reader.EndOfStream)
                        {
                            String courseName = reader.ReadLine();
                            foreach(Course course in allCourses)
                            {
                                if (course.getName().Equals(courseName))
                                {
                                    programCourses.Add(course);
                                }
                            }
                        }

                        programs.Add(new FacultyProgram(programName, programHead, programCourses));
                        reader.Close();
                    }

                }
            }

            return programs;
        }

        public static void setNewAdmin(Lecturer lecturer)
        {
            List<FacultyProgram> headPrograms = new List<FacultyProgram>();
            List<Lecturer> headStaff = new List<Lecturer>();
            List<Student> headStudents = new List<Student>();
            HeadDepartment newHead = new HeadDepartment(lecturer, headPrograms, headStaff, headStudents);
            using (StreamWriter writer = new StreamWriter("..\\..\\Files\\HeadDepartment.txt", true))
            {
                writer.WriteLine(newHead.ToString());
                writer.Close();
            }

            List<Lecturer> updatingLecs = reloadLecturers();
            updatingLecs.Remove(lecturer);
            String filePath = "..\\..\\Files\\Lecturers.txt";
            using (StreamWriter w = new StreamWriter(filePath, false))
            {
                foreach(Lecturer newLecturer in updatingLecs) 
                {
                    w.WriteLine(newLecturer.ToString());
                    
                }
                w.Close();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork3
{
    public class LinqService
    {
        private List<Student> Students { get; set; }
        public LinqService(List<Student> students)
        {
            Students = students;
        }
        public List<Student> GetAllStudents()
        {
            var result =
                (from student in Students
                 select student).ToList();
            return result;
        }
        public List<Student> GetStudentsByLastName()
        {
            var result =
                (from student in Students
                 where student.LastName.StartsWith("Bro")
                 select student).ToList();
            return result;
        }
        public List<Student> GetStudentsOlderThan19()
        {
            var result =
                (from student in Students
                 where student.Age > 19
                 select student).ToList();
            return result;
        }
        public List<Student> GetStudentsBetween20And23()
        {
            var result =
                (from student in Students
                 where student.Age > 20 && student.Age < 23
                 select student).ToList();
            return result;
        }
        public List<Student> GetOxfordStudents()
        {
            var result =
                (from student in Students
                 where student.University == "Oxford" && student.Age > 18
                 orderby student.Age 
                 select student).ToList();
            return result;
        }
    }
}

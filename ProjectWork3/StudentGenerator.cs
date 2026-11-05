using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork3
{
    public class StudentGenerator
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>()
            {
                new Student("John", "Brown", 19, "Oxford"),
                new Student("Michael", "Brooks", 22, "Oxford"),
                new Student("David", "Smith", 21, "Cambridge"),
                new Student("James", "Browning", 23, "Oxford"),
                new Student("Robert", "Wilson", 18, "Harvard"),
                new Student("William", "Broderick", 24, "Oxford"),
                new Student("Daniel", "Taylor", 20, "Oxford"),
                new Student("Thomas", "Brown", 22, "Harvard"),
                new Student("Oliver", "Johnson", 21, "Oxford"),
                new Student("Henry", "Brooks", 19, "Cambridge")
            };
            return students;
        }
    }
}

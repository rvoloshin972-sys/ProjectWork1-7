using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork3
{
    public record class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
        public Student(string firstName, string lastName, int age, string university)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            University = university;
        }
    }
}

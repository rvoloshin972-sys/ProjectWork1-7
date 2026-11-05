using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork7
{
    internal class Employee
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Employee(string fullName,string position,string phone,string email,decimal salary)
        {
            FullName = fullName;
            Position = position;
            Phone = phone;
            Email = email;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"ПІБ: {FullName}\n" +
                   $"Посада: {Position}\n" +
                   $"Телефон: {Phone}\n" +
                   $"Email: {Email}\n" +
                   $"Заробітна плата: {Salary} грн";
        }
    }
}

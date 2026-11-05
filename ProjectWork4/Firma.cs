using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork4
{
    internal class Firma
    {
        public string Name { get; set; }
        public DateTime DateFounded { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }
        public Firma(string name,DateTime dateFounded,string businessProfile,string directorFullName,int employeesCount,string address)
        {
            Name = name;
            DateFounded = dateFounded;
            BusinessProfile = businessProfile;
            DirectorFullName = directorFullName;
            EmployeesCount = employeesCount;
            Address = address;
        }
        public override string ToString()
        {
            return $"Назва: {Name}\n" +
                   $"Дата заснування: {DateFounded:dd.MM.yyyy}\n" +
                   $"Профіль бізнесу: {BusinessProfile}\n" +
                   $"Директор: {DirectorFullName}\n" +
                   $"Кількість працівників: {EmployeesCount}\n" +
                   $"Адреса: {Address}\n";
        }
    }
}

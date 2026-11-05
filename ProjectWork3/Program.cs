using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork3
{
    public record class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> students = StudentGenerator.GetStudents();
            LinqService service = new LinqService(students);

            Console.WriteLine("Весь масив студентів:");
            PrintStudents(service.GetAllStudents());

            Console.WriteLine("\nСтуденти, прізвище яких починається з Bro:");
            PrintStudents(service.GetStudentsByLastName());

            Console.WriteLine("\nСтуденти старші 19 років:");
            PrintStudents(service.GetStudentsOlderThan19());

            Console.WriteLine("\nСтуденти старші 20 і молодші 23 років:");
            PrintStudents(service.GetStudentsBetween20And23());

            Console.WriteLine("\nСтуденти Oxford старші 18 років (за спаданням віку):");
            PrintStudents(service.GetOxfordStudents());

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
            static void PrintStudents(List<Student> students)
            {
                foreach (Student student in students)
                {
                    Console.WriteLine(
                        $"Ім'я: {student.FirstName}, " +
                        $"Прізвище: {student.LastName}, " +
                        $"Вік: {student.Age}, " +
                        $"Навчальний заклад: {student.University}");
                }
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork7
{
    internal class Program
    {
        static void PrintEmployees(string title,IEnumerable<Employee> employees)
        {
            Console.WriteLine("\n" + title);
            Console.WriteLine("");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var foodEmployees = new List<Employee>
            {
                new Employee("Lionel Messi","Менеджер","231234567","lionel@gmail.com",60000),
                new Employee("John Smith","Програміст","501234567","john@gmail.com",45000),
                new Employee("David Brown","Менеджер","231112233","david@gmail.com",75000)
            };

            var itEmployees = new List<Employee>
            {
                new Employee("Michael White","Програміст","671234567","michael@gmail.com",55000),
                new Employee("Lionel Anderson","Тестувальник","239876543","director@gmail.com",40000),
                new Employee("Peter Black","Менеджер","231234890","peter@gmail.com",80000)
            };

            var marketingEmployees = new List<Employee>
            {
                new Employee("Robert Green","Маркетолог","991234567","robert@gmail.com",35000),
                new Employee("Andrew Wilson","Менеджер","231234111","andrew@gmail.com",50000),
                new Employee("Thomas Brown","Дизайнер","501234890","design@gmail.com",42000)
            };

            Firma[] firms =
            {
                new Firma("Food Market",new DateTime(2018, 5, 10),"Торгівля","John White",150,"London, Oxford Street",foodEmployees),
                new Firma("IT Solutions",new DateTime(2020, 3, 15),"IT","Michael Black",250,"London, Baker Street",itEmployees),
                new Firma("Marketing Group",new DateTime(2019, 7, 20),"Маркетинг","David Brown",80,"Paris, Main Street",marketingEmployees)
            };

            string firmaName = "Food Market";
            decimal salary = 50000;

            var allEmployees =
                from firma in firms
                from employee in firma.Employees
                where firma.Name == firmaName
                select employee;
            PrintEmployees("1. УСІ ПРАЦІВНИКИ ФІРМИ FOOD MARKET:",allEmployees);

            var employeesWithHighSalary =
                from firma in firms
                from employee in firma.Employees
                where firma.Name == firmaName
                where employee.Salary > salary
                select employee;
            PrintEmployees("2. ПРАЦІВНИКИ З ЗАРПЛАТОЮ БІЛЬШЕ 50000:",employeesWithHighSalary);

            var managers =
                from firma in firms
                from employee in firma.Employees
                where employee.Position == "Менеджер"
                select employee;
            PrintEmployees("3. УСІ ПРАЦІВНИКИ З ПОСАДОЮ МЕНЕДЖЕР:",managers);

            var employeesByPhone =
                from firma in firms
                from employee in firma.Employees
                where employee.Phone.StartsWith("23")
                select employee;
            PrintEmployees("4. ПРАЦІВНИКИ, ТЕЛЕФОН ЯКИХ ПОЧИНАЄТЬСЯ З 23:",employeesByPhone);

            var employeesByEmail =
                from firma in firms
                from employee in firma.Employees
                where employee.Email.StartsWith("di")
                select employee;
            PrintEmployees("5. ПРАЦІВНИКИ, EMAIL ЯКИХ ПОЧИНАЄТЬСЯ З DI:",employeesByEmail);

            var lionelEmployees =
                from firma in firms
                from employee in firma.Employees
                where employee.FullName.Split(' ')[0] == "Lionel"
                select employee;
            PrintEmployees("6. ПРАЦІВНИКИ З ІМ'ЯМ LIONEL:",lionelEmployees);

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

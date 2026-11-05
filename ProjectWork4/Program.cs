using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork4
{
    internal class Program
    {
        static void PrintFirms(string title, IEnumerable<Firma> firms)
        {
            Console.WriteLine("\n" + title);
            Console.WriteLine("");
            foreach (var firma in firms)
            {
                Console.WriteLine(firma);
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Firma[] firms =
            {
                new Firma("Food Market",new DateTime(2018, 5, 10),"Торгівля","John White",150,"London, Oxford Street"),
                new Firma("IT Solutions",new DateTime(2020, 3, 15),"IT","Michael Black",250,"London, Baker Street"),
                new Firma("Marketing Group",new DateTime(2019, 7, 20),"Маркетинг","David Brown",80,"Paris, Main Street"),
                new Firma("White Food Company",DateTime.Today.AddDays(-123),"Харчова промисловість","Robert Black",120,"London, Green Street"),
                new Firma("Digital World",new DateTime(2024, 2, 10),"IT","James White",50,"Berlin, Central Street"),
                new Firma("Marketing Plus",new DateTime(2022, 8, 15),"Маркетинг","Peter Wilson",300,"London, King Street"),
                new Firma("Food Service",new DateTime(2021, 6, 12),"Ресторанний бізнес","Thomas Black",90,"Rome, Main Street"),
                new Firma("White Technology",new DateTime(2017, 4, 5),"IT","Andrew White",400,"London, Park Street")
            };
            var allFirms =
                from firma in firms
                select firma;
            PrintFirms("1. ВСІ ФІРМИ:", allFirms);

            var foodFirms =
                from firma in firms
                where firma.Name.Contains("Food")
                select firma;
            PrintFirms("2. ФІРМИ ЗІ СЛОВОМ FOOD:", foodFirms);

            var marketingFirms =
                from firma in firms
                where firma.BusinessProfile == "Маркетинг"
                select firma;
            PrintFirms("3. ФІРМИ У ГАЛУЗІ МАРКЕТИНГУ:", marketingFirms);

            var marketingOrIT =
                from firma in firms
                where firma.BusinessProfile == "Маркетинг"
                   || firma.BusinessProfile == "IT"
                select firma;
            PrintFirms("4. ФІРМИ У ГАЛУЗІ МАРКЕТИНГУ АБО IT:", marketingOrIT);

            var moreThan100 =
                from firma in firms
                where firma.EmployeesCount > 100
                select firma;
            PrintFirms("5. ФІРМИ З ПРАЦІВНИКАМИ БІЛЬШЕ 100:", moreThan100);

            var from100To300 =
                from firma in firms
                where firma.EmployeesCount >= 100
                   && firma.EmployeesCount <= 300
                select firma;
            PrintFirms("6. ФІРМИ ВІД 100 ДО 300 ПРАЦІВНИКАМИ:", from100To300);

            var londonFirms =
                from firma in firms
                where firma.Address.Contains("London")
                select firma;
            PrintFirms("7. ФІРМИ У ЛОНДОНІ:", londonFirms);

            var whiteDirectors =
                from firma in firms
                where firma.DirectorFullName.EndsWith("White")
                select firma;
            PrintFirms("8. ФІРМИ З ДИРЕКТОРОМ WHITE:", whiteDirectors);

            var olderThanTwoYears =
                from firma in firms
                where firma.DateFounded < DateTime.Today.AddYears(-2)
                select firma;
            PrintFirms("9. ФІРМИ, ЗАСНОВАНІ БІЛЬШЕ ДВОХ РОКІВ ТОМУ:", olderThanTwoYears);

            var founded123Days =
                from firma in firms
                where firma.DateFounded.Date == DateTime.Today.AddDays(-123)
                select firma;
            PrintFirms("10. ФІРМИ, ЗАСНОВАНІ 123 ДНІ ТОМУ:", founded123Days);

            var blackAndWhite =
                from firma in firms
                where firma.DirectorFullName.EndsWith("Black") && firma.Name.Contains("White")
                select firma;
            PrintFirms("11. ДИРЕКТОР BLACK І НАЗВА WHITE:", blackAndWhite);

            Console.WriteLine("\nНатисніть будь-яку клавішу для завершення...");
            Console.ReadKey();
        }
    }
}

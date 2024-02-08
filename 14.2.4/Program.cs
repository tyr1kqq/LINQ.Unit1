using System.Runtime.InteropServices;

namespace _14._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                 new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                 new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                 new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };
            var coarses = new List<Coarse>
            {
             new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
             new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };
            var studentsWithCoarses = from stud in students
                                      where (stud.Age < 29 && stud.Languages.Contains("английский"))
                                      let BithYear = DateTime.Now.Year - stud.Age
                                      from cours in coarses
                                      where (cours.Name.Contains("C#"))
                                      select new { Name = stud.Name, CoarseName = cours.Name , BithYear };

            foreach ( var stud in studentsWithCoarses )
            {
                Console.WriteLine( "Студент  " + stud.BithYear + " " +  stud.Name + "  Добавлен на курс  " + stud.CoarseName );
            }

        }
    }
}
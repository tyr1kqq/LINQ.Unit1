using System.Linq;

namespace LINQ.Unit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян", "ААААА", "Аб" };

            var selectPeople = from p in people
                               where p.StartsWith("А")
                               orderby p
                               select p;

            foreach (var p in selectPeople)
                Console.WriteLine(p);

            Console.WriteLine();

            var objects = new List<object>()
            {
             1,
             "Сергей ",
             "Андрей ",
             300,
            };

           foreach ( var selectobj in objects.Where(o =>o is string).OrderBy(o => o))
                            Console.WriteLine(selectobj);
                            

           

        }
    }
}
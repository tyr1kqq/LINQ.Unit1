namespace _14._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var wordsAplication = words.Select(w => new
            {
                name = w,
                leght = w.Length
            })
            .OrderBy(w => w.leght) ;

            foreach (var word in wordsAplication)
                Console.WriteLine(word);
        }
    }
}
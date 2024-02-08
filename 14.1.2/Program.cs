namespace _14._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = { "Раз два три",
               "четыре пять шесть",
               "семь восемь девять" };

            var Words = from str in text
                        from word in str.Split(' ')
                        select word;

            foreach (var word in Words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =
            {
            1,
            2,
            3,
            4,
            10,
            34,
            55,
            66,
            77,
            88
            };

            var evenNums = from i in numbers.Where(i => i % 2 == 0 && i > 10) select i;

            foreach (var I in evenNums)
            {
                Console.WriteLine(I);
            }
        }
    }
}
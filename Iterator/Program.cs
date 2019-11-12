using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testData = {1, 4, 3, 0, 32, 55, 0, 0, 123, 456, 0, 77, 0};
            IterableArray a = new IterableArray(testData);
            Console.WriteLine("Iteracja po wszystkich elementach");
            foreach (var elem in a.Elements)
            {
                Console.Write(elem + ", ");
            }
            Console.Write("\n");
            Console.WriteLine("Iteracja po niezerowych elementach");
            foreach (var elem in a.NonZeroElements)
            {
                Console.Write(elem + ", ");
            }
        }
    }
}
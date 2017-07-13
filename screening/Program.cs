using System;
using System.Linq;

namespace screening
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {0,9,8,3,3,5,9,5,0};
            numbers = SimplifyNumbers.Simplify(numbers);
            foreach(var num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        }

        public static class SimplifyNumbers
        {
            public static int[] Simplify (int[] numbers){
                Array.Sort(numbers);
                return numbers.Distinct().ToArray();
            }
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Task01_Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<char> sentence = Console.ReadLine().ToList();

            for (int i = 0; i <= numbers.Count - 1; i++)
            {
                int index = GetSum(numbers[i]);

                //Console.WriteLine(index);

                //Console.WriteLine(sentence[index]);

                while(index > sentence.Count - 1)
                {
                    index = index - (sentence.Count);
                }

                Console.Write(sentence[index]);
                sentence.RemoveAt(index);
            }
        }

        private static int GetSum(int nextNumber)
        {
            int result = 0;
            

            while (nextNumber >= 1)
            {
                int nextDigit = nextNumber % 10;
                result += nextDigit;
                nextNumber = nextNumber / 10;
            }
            
            return result;
        }
    }
}

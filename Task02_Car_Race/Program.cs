using System;
using System.Linq;
using System.Collections.Generic;

namespace Task02_Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            double leftTime = 0;
            double rightTime = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                
                if (numbers[i] == 0)
                {
                    leftTime *= 0.8;
                }
                else
                {
                    leftTime += numbers[i];
                }


                
                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    rightTime *= 0.8;
                }
                else
                {
                    rightTime += numbers[numbers.Count - 1 - i];
                }


            }

            /*
            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                rightTime += numbers[i];
                if (numbers[i] == 0)
                {
                    rightTime *= 0.8;
                }
            }
            */
            
            if(leftTime < rightTime)
            {
                Console.WriteLine($"The winner is left with total time: {leftTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightTime}");
            }
        }
    }
}

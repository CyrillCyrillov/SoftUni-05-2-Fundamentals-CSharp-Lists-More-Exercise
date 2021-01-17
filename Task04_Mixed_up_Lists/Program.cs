using System;
using System.Linq;
using System.Collections.Generic;

namespace Task04_Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> leftList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> rightList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> mixedList = new List<int>(leftList.Count + rightList.Count - 2);

            while (leftList.Count > 2 || rightList.Count > 2)
            {
                mixedList.Add(leftList[0]);
                leftList.RemoveAt(0);

                mixedList.Add(rightList[rightList.Count - 1]);
                int helpIndex = rightList.Count - 1;
                rightList.RemoveAt(helpIndex);
            }

            int startNumber = int.MinValue;
            int endNumber = int.MaxValue;


            if(leftList.Count == 0)
            {
                startNumber = rightList.Min();
                endNumber = rightList.Max();
            }
            else
            {
                startNumber = leftList.Min();
                endNumber = leftList.Max();
            }

            mixedList.RemoveAll(x => x <= startNumber);
            mixedList.RemoveAll(x => x >= endNumber);


            mixedList.Sort();

            Console.WriteLine(string.Join(' ', mixedList));
        }
    }
}

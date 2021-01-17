using System;
using System.Collections.Generic;
using System.Linq;

namespace Task05_Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double saveMoney = double.Parse(Console.ReadLine());
            int[] drumSetBegin = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> drumSet = drumSetBegin.ToList();

            while (true)
            {
                string comand = Console.ReadLine();
                if(comand.ToUpper() == "HIT IT AGAIN, GABSY!")
                {
                    break;
                }

                int hitpower = int.Parse(comand);

                for (int i = 0; i <= drumSet.Count - 1; i++)
                {
                    if(drumSet[i] > 0)
                    {
                        drumSet[i] -= hitpower;
                        if (drumSet[i] <= 0)
                        {
                            double neededMoney = drumSetBegin[i] * 3;
                            if (neededMoney <= saveMoney)
                            {
                                drumSet[i] = drumSetBegin[i];
                                saveMoney -= neededMoney;
                            }
                        }
                    }
                    
                }
            }

            for (int i = 0; i <= drumSet.Count - 1; i++)
            {
                if(drumSet[i] <= 0)
                {
                    drumSet.RemoveAt(i);
                    i -= 1;
                }
            }
            Console.WriteLine(string.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {saveMoney:f2}lv.");
        }
    }
}

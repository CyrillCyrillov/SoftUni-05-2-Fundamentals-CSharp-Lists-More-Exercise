using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Task03_Take_Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string codeMessage = Console.ReadLine();

            List<int> numbersList = new List<int>();
            List<string> noNumbersList = new List<string>();

            for (int i = 0; i <= codeMessage.Length - 1 ; i++)
            {
                if(codeMessage[i] >= 48 && codeMessage[i] <= 57 )
                {
                    numbersList.Add(int.Parse(codeMessage[i].ToString()));
                }
                else
                {
                    noNumbersList.Add(codeMessage[i].ToString());
                }
            }

            List<int> takeEven = new List<int>();
            List<int> skipOdd = new List<int>();

            for (int i = 0; i <= numbersList.Count - 1; i++)
            {
                if(i % 2 == 0)
                {
                    takeEven.Add(numbersList[i]);
                }
                else
                {
                    skipOdd.Add(numbersList[i]);
                }
            }

            int indexForSkip = 0;
            StringBuilder realMessage = new StringBuilder();

            for (int i = 0; i < takeEven.Count; i++)
            {
                List<string> temp = new List<string>(noNumbersList);

                temp = temp.Skip(indexForSkip).Take(takeEven[i]).ToList();

                realMessage.Append(string.Join("", temp));

                indexForSkip += takeEven[i] + skipOdd[i];
            }

            Console.WriteLine(realMessage.ToString());


            //Console.WriteLine(string.Join(", ", numbersList));
            //Console.WriteLine(string.Join(", ", noNumbersList));
        }
    }
}

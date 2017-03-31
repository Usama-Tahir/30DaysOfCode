using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day10
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            int remainder = 0;
            int totalNumberOfN = 0;
            int? previousN = null;        // nullable int
            int temp = 0;
            while (N > 0)
            {
                remainder = N % 2;
                N = N / 2;
                list.Add(remainder);
            }
            list.Reverse();
            foreach (int i in list)
            {
                //Console.Write(i);
                if (i == 1 && previousN == null)
                {
                    temp++;
                    previousN = i;
                }
                else if (i == 0 && previousN == 1)
                {
                    if (temp >= totalNumberOfN)
                    {
                        totalNumberOfN = temp;
                    }
                    temp = 0;
                    previousN = i;
                }
                else if (i == i && previousN == 0)
                {
                    temp++;
                    if (temp >= totalNumberOfN)
                    {
                        totalNumberOfN = temp;
                    }
                    previousN = i;
                }
                else if (i == 0 && previousN == 0)
                {
                    continue;
                }
                else if (i == 1 && previousN == 1)
                {
                    temp++;
                    if (temp >= totalNumberOfN)
                    {
                        totalNumberOfN = temp;
                    }
                    previousN = i;
                }


            }
            Console.Write(totalNumberOfN);
        }
    }
}

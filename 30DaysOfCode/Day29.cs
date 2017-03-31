using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day29
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                int max = 0;
                for (int i = 1; i < n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        int h = i & j;
                        if (h < k && max < h) max = h;
                    }
                }
                Console.WriteLine(max);

            }
        }
    }
}

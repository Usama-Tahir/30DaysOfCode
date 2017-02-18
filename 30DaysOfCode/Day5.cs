// Loops

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day5
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                int result = n * i;
                Console.WriteLine(n + " x " + i + " = " + result);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day16
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int N;
            try
            {
                N = int.Parse(S);
                Console.WriteLine(N);
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
            
        }
    }
}

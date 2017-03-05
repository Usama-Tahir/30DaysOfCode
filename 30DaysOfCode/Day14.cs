//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysOfCode
//{

//    class Difference
//    {
//        private int[] elements;
//        public int maximumDifference;
//        public Difference(int[] num)
//        {
//            elements = num;
//        }
//        public void computeDifference()
//        {
//            Array.Sort(elements);
//            maximumDifference = elements[elements.Length - 1] - elements[0];
//        }
//    }

//    class Solution
//    {
//        static void Main(string[] args)
//        {
//            Convert.ToInt32(Console.ReadLine());

//            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

//            Difference d = new Difference(a);

//            d.computeDifference();

//            Console.Write(d.maximumDifference);
//        }
//    }
//}

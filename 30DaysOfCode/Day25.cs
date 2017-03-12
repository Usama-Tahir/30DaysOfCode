//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysOfCode
//{
//    class Day25
//    {
//        static bool checkPrime(int num)
//        {
//            if (num < 2) return false;
//            if (num == 2) return true;
//            if (num % 2 == 0) return false;
//            for(int i=3;i<=Math.Sqrt(num);i++)
//            {
//                //Console.WriteLine(Math.Sqrt(num));         // for debugging
//                if (num % i == 0) return false;
//            }
//            return true;
//        }
//        static void Main(string[] args)
//        {
//            int num = Convert.ToInt32(Console.ReadLine());
//            List<int> list = new List<int>();
//            while(num>0)
//            {
//                int temp = Convert.ToInt32(Console.ReadLine());
//                list.Add(temp);
//                num--;
//            }
//            foreach(int numb in list)
//            {
//                if (checkPrime(numb))
//                    Console.WriteLine("Prime");
//                else
//                    Console.WriteLine("Not prime");
//            }
//        }
//    }
//}

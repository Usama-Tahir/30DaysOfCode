//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysOfCode
//{
//    class Day26
//    {
//        static void Main(string[] args)
//        {
//            int fine = 0;
//            string[] actual_return = Console.ReadLine().Split(' ');
//            int[] arr2 = Array.ConvertAll(actual_return, Int32.Parse);

//            int actual_day = arr2[0];
//            int actual_month = arr2[1];
//            int actual_year = arr2[2];

//            string[] expected_return = Console.ReadLine().Split(' ');
//            int[] arr = Array.ConvertAll(expected_return, Int32.Parse);

//            int expected_day = arr[0];
//            int expected_month = arr[1];
//            int expected_year = arr[2];


//            if (actual_year <= expected_year && actual_month <= expected_month && actual_day <= expected_day)
//                fine = 0;
//            else if(actual_year >= expected_year && actual_month >= expected_month && actual_day >= expected_day)
//            {
//               if((actual_month==1 || actual_month==3|| actual_month==5|| actual_month==7 || actual_month==8 || actual_month==10 || actual_month==12) &&
//                    (expected_month==1 || expected_month==3 || expected_month==5 || expected_month==7 || expected_month==8 || expected_month==10 || expected_month==12))
//                {
                    
//                }

//                if ((actual_month == 1 || actual_month == 3 || actual_month == 5 || actual_month == 7 || actual_month == 8 || actual_month == 10 || actual_month == 12) &&
//                     (expected_month == 4 || expected_month == 6 || expected_month == 9 || expected_month == 11))
//                {

//                }

//                else if ((actual_month == 4 || actual_month == 6 || actual_month == 9 || actual_month == 11) &&
//                    (expected_month == 1 || expected_month == 3 || expected_month == 5 || expected_month == 7 || expected_month == 8 || expected_month == 10 || expected_month == 12))
//                {

//                }

//               else if ((actual_month == 4 || actual_month == 6 || actual_month == 9 || actual_month == 11) &&
//                    (expected_month == 4 || expected_month == 6 || expected_month == 9 || expected_month == 11))
//                {

//                }
//                else if ((actual_month == 1 || actual_month == 3 || actual_month == 5 || actual_month == 7 || actual_month == 8 || actual_month == 10 || actual_month == 12) &&
//                    (expected_month == 2 ))
//                {

//                }

//               else if ((actual_month == 2) &&
//                    (expected_month == 1 || expected_month == 3 || expected_month == 5 || expected_month == 7 || expected_month == 8 || expected_month == 10 || expected_month == 12))
//                {

//                }


//            }
//            Console.WriteLine(fine);
//            Console.ReadLine();

            
            
//        }
//    }
//}

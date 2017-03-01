//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//class Solution
//{

//    static void Main(String[] args)
//    {
//        int[][] arr = new int[6][];
//        int largest_Maximum = -50;          // there is a reason to set this value to negative 50...
//        for (int arr_i = 0; arr_i < 6; arr_i++)
//        {
//            string[] arr_temp = Console.ReadLine().Split(' ');
//            arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
//        }
//        for(int i=0;i<arr.Length-2;i++)
//        {
//            for(int j=0;j<arr.Length-2;j++)
//            {
//                //Console.Write(arr[i][j]);
//                //Console.Write(" ");
//                int temp_row = i;
//                int temp_col = j;
//                int local_maximum = 0;
//                for(int a = temp_row;a<=temp_row+2;a++)
//                {
//                    for(int b=temp_col;b<=temp_col+2;b++)
//                    {
//                       if (a == temp_row + 1 && (b == temp_col || b == temp_col + 2))
//                        {
//                            //Console.Write(" ");
//                            continue;
//                        }
//                        //if (a == 0)
//                        //{
//                        //    largest_Maximum += arr[a][b];
//                        //}
//                        local_maximum += arr[a][b];
//                       // Console.Write(arr[a][b]);
//                        //Console.Write(" ");
//                    }
                   
//                }
                
                
//                if (local_maximum >= largest_Maximum)
//                    largest_Maximum = local_maximum;
               
//            }
           
//            //Console.Write(" ");
//            //Console.Write(" ");
//            //Console.Write(" ");
//            //Console.Write(" ");
//            //Console.Write(" ");
//        }
//        Console.Write(largest_Maximum);
        
//    }
//}

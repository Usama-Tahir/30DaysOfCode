 Name : Usama Tahir

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Day7
    {

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = arr[i];
                //Console.Write(A[i]+" ");
            }
            //Console.WriteLine(A.Length);
            for (int i = (A.Length - 1); i >= 0; i--)
            {
                Console.Write(A[i] + " ");
            }


        }





    }
}

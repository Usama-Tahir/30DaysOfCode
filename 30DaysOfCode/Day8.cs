// Name: Usama Tahir
// trying to get things traight
 hehhehe
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Solution
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();
            IList<string> queryList = new List<string>();
            int n = Convert.ToInt32(Console.ReadLine());
            string tempName = "";
            int tempNumb = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                tempName = arr[0];
                tempNumb = int.Parse(arr[1]);
                phoneBook.Add(tempName, tempNumb);
                //Console.WriteLine(tempName + "  " + tempNumb);
            }
            string input = "";
            for (int l = 1; l <= n; l++)
            {
                input = Console.ReadLine();
                queryList.Add(input);

            }


            foreach (string inp in queryList)
            {
                //Console.WriteLine(inp);
                if (phoneBook.ContainsKey(inp))
                {
                    Console.WriteLine(inp + "=" + phoneBook[inp]);
                }
                else if (!phoneBook.ContainsKey(inp) && inp != "end")
                {
                    Console.WriteLine("Not found");
                }
            }


        }



    }
}

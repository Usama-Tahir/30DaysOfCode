using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> list = new List<string>();
        char delimeter = '@';
        for (int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            string[] temp = emailID.Split(delimeter);
            if (temp[1] == "gmail.com")
            {
                list.Add(firstName);
            }


        }
        list.Sort();
        foreach (string pair in list)
        {
            Console.WriteLine(pair);
        }
    }
}

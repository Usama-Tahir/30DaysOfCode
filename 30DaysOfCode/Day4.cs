// Name : Usama Tahir
// HACKER RANK 30 DAYS OF CHALLENGE
// Classes vs Instances


using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public int age;
    public Person(int initialAge)
    {
        if (initialAge >= 0)
            this.age = initialAge;
        else if (initialAge < 0)
        {
            this.age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }   
    }
    public void yearPasses()
    {
        this.age++;
    }
    public void amIOld()
    {
        if (this.age < 13)
            Console.WriteLine("You are young.");
        else if (this.age >= 13 && this.age < 18)
            Console.WriteLine("You are a teenager.");
        else
            Console.WriteLine("You are old.");
    }

}

namespace _30DaysOfCode
{
    class Day4
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            Person one = new Person(T);

        }

    }
}

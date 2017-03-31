using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    using System;
    using System.Linq;

    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        int[] testScores;
        public Student() { }
        public Student(string firstName, string lastName, int id, int[] testScores) : base(firstName, lastName, id)
        {

            this.testScores = testScores;
        }
        public char Calculate()
        {
            int temp = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                temp += testScores[i];
            }
            temp = temp / testScores.Length;
            if (temp > 0 && temp < 40)
                return 'T';
            else if (temp >= 40 && temp < 55)
                return 'D';
            else if (temp >= 55 && temp < 70)
                return 'P';
            else if (temp >= 70 && temp < 80)
                return 'A';
            else if (temp >= 80 && temp < 90)
                return 'E';
            else if (temp >= 90 && temp <= 100)
                return 'O';
            else
                return '0';

        }


    }

    class Solution
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}

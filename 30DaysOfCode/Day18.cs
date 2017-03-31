using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// only implemented functionality needed to be implemented...
// Remaining code is at HackerRank (30 Days of Code Day 18)
namespace _30DaysOfCode
{

    class Day18
    {
        Queue<char> collection = new Queue<char>();
        Stack<char> stack = new Stack<char>();
        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }
        public void enqueueCharacter(char ch)
        {
            collection.Enqueue(ch);
        }
        public char popCharacter()
        {
            return stack.Pop();
        }
        public char dequeueCharacter()
        {
            return collection.Dequeue();
        }
    }
}

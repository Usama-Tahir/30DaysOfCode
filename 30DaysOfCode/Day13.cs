//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _30DaysOfCode
//{
//    using System;
//    using System.Collections.Generic;
//    using System.IO;
//    abstract class Book
//    {

//        protected String title;
//        protected String author;

//        public Book(String t, String a)
//        {
//            title = t;
//            author = a;
//        }
//        public abstract void display();


//    }

//    class MyBook : Book
//    {
//        int price;
//       public MyBook(string title, string author, int p) : base(title,author)
//        {
//            price = p;
//        }
//        public override void display()
//        {
//            //throw new NotImplementedException();
//            Console.WriteLine("Title: " + title);
//            Console.WriteLine("Author: " + author);
//            Console.WriteLine("Price: " + price);
//        }
//    }
//    class Solution
//    {
//        static void Main(String[] args)
//        {
//            String title = Console.ReadLine();
//            String author = Console.ReadLine();
//            int price = Int32.Parse(Console.ReadLine());
//            Book new_novel = new MyBook(title, author, price);
//            new_novel.display();
//        }
//    }
//}

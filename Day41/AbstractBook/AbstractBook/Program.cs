using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AbstractBook
{
    abstract class Book
    {
        string title;
        public abstract void setTitle(string s);
        //public string getTitle()
        //{
            //return title;
        //}

    }
    class MyBook : Book
    {
        public override void setTitle(string s)
        {
            Console.WriteLine("The title is : {0}",s);
            
        }
    }

    public class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Book Name : ");
            string str=Console.ReadLine();

            MyBook book = new MyBook();
            book.setTitle(str);
        }
    }
}

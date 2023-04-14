using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Enter 2 nos in ascending order and print nos b/w them

            Console.WriteLine("Enter the first no : ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no : ");
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine($"The numbers between {a} and {b} is : ");
            for(int i=a+1;i<b;i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}

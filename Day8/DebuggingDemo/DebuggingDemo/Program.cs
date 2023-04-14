using System;

namespace DebuggingDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first no : ");
            int i=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second no : ");
            int j=int.Parse(Console.ReadLine());
            foo(i, j);
            Console.WriteLine("Debugging Over");            

        }
        public static void foo(int x,int y)
        {
            int t = 100;
            for(int i = x; i <= y; i++)
            {
                Console.WriteLine("India");
                t = t + 34;
            }
        }
    }
}

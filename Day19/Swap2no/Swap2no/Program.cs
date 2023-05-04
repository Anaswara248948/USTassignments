using System;



namespace Swap2no
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no : ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no : ");
            int b=int.Parse(Console.ReadLine());

            swapping(ref a, ref b);
            Console.WriteLine("Result after swapping {0},{1}",a,b);
        }
        public static void swapping(ref int x, ref int y)
        {
            int z;
            z = x;
            x = y;
            y = z;
        }        
    }
}

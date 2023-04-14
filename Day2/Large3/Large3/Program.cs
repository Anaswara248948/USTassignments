using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Large3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd no : ");
            int c = int.Parse(Console.ReadLine());
            int large;
            large=Largest(a,b,c);
            Console.WriteLine("The largest no is "+large);
        }
        static int Largest(int x, int y, int z)
        {
            if (x > y)
            
                if (x > z)
                {
                    return x;
                }
                else
                {
                    return y;
                }
             else if(y>z)
                {
                return y;
                }
            else
            {
                return z;
            }    
        }
    }
}

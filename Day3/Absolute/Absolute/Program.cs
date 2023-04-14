using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Absolute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int ab = 0;
            Console.WriteLine("Enter the number : ");
            n = int.Parse(Console.ReadLine());

            ab = Calculate(n);
            Console.WriteLine("The difference is : " + ab);

        }
        public static int Calculate(int x)
        {
            if (x < 51)
            {
                return 51 - x;
            }
            else if (x > 51)
            {
                return (x - 51) * 3;
            }
            else
            {
                return 0;
            }
        }  
        
    }
}

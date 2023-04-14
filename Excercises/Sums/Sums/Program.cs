using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum=0;

            Console.WriteLine("Enter first no : ");
            int a=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second no : ");
            int b = int.Parse(Console.ReadLine());

            sum = CountSum(a, b);
            Console.WriteLine("The sum is : " + sum);

        }

        static int CountSum(int x, int y)
        {
            if(x==y)
            {
                return (x + y) * 3;
            }
            else
            {
                return x + y;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2 :");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = num1 + num2;
            BigInteger prod = num1 * num2;
            Console.WriteLine(sum);
            Console.WriteLine(prod);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adder add1 = new Adder();
            int s = add1.Add(42,13);
            Console.WriteLine("My super class is: Arithmetic");
            Console.WriteLine("The Sum is: "+s);
        }
    }
}

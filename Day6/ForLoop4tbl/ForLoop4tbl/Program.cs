using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop4tbl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the number : ");
            int n=int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                int s = n * i;
                //Console.WriteLine("{0} * {1} = {2}",n,i,s);
                Console.WriteLine($"{n} * {i} = {s}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop5ptrn1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*\t");
                }
               Console.WriteLine("\n");
            }

        }
    }
}

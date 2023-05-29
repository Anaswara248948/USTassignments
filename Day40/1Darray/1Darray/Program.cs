using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //4

            Console.WriteLine("enter the size : ");
            int n=int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the elements of array : ");
            for(int i=0; i<n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i=0; i<n;i++)
            {
                Console.WriteLine("{0}", a[i]);
            }
        }
    }
}

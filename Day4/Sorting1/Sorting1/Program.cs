using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SELECTION SORTING

            int temp;
            int[] arr1 = { 33, 92, 11, 56, 28, 5 };
            int n=arr1.Length;

            for(int i=0; i<n-1; i++)
            {
                for(int j=i+1; j<n; j++)
                {
                    if (arr1[i] > arr1[j])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array is \n");
            for(int i=0; i<n; i++)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BUBBLE SORTING

            int temp;

            //int[] arr1 = { 33, 92, 11, 56, 28, 5 };
            int[] arr1 = { 30, 92, 3, 25, 67, 13 };

            int n = arr1.Length;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (arr1[j] > arr1[j+1])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j+1];
                        arr1[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("The sorted array is \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i] + "\t");
            }
            Console.WriteLine();

        }
    }
}

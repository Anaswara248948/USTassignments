using System;
using System.Collections.Generic;


namespace MissingNo
{
    public class Program
    {
        static void Main(string[] args)
        {

            int N = 5;
            int[] A = { 1, 2, 3, 5 };
            int missno = FindNo(N,A);
            Console.WriteLine("Missing element in array is : "+missno);
        }
        public static int FindNo(int n, int[] arr)
        {
            int sum = (n*(n + 1))/2;
            int arrsum = 0;
            for(int i=0; i<arr.Length;i++)
            {
                arrsum = arrsum + arr[i];
            }
            return sum-arrsum;
        }
    }
}

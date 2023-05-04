using System;
using System.Collections;
using System.Collections.Generic;

namespace SumOfArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter no of elements : ");
            int N=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter sum : ");
            int S=int.Parse(Console.ReadLine());
            int[] arr=new int[N];

            ArrayList list1 = new ArrayList();

            Console.WriteLine("Enter array elements : ");
            
            for(int i=0; i<N; i++)
            {
                
                    arr[i] = int.Parse(Console.ReadLine());
                
            }

            for(int i=0;i<N;i++)
            {
                sum = arr[i];
                if(sum == S)
                {
                    Console.WriteLine("Subarrays starts at {0}", i);
                    return;
                }
                else
                {
                    for(int j=i+1;j<N;j++)
                    {
                        sum = sum + arr[j];
                        if(sum==S)
                        {
                            Console.WriteLine("Starts at {0} and end at {1}", i + 1, j + 1);
                            return;
                        }
                    }
                }
            }

        }
    }
}

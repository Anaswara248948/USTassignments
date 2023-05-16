using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of elements in an array : ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("enter the target : ");
            int target =int.Parse(Console.ReadLine());
            int[] nums = new int[n];            
            Console.WriteLine("Enter array elements");
            for(int i=0;i<n;i++)
            {
                nums[i]=int.Parse(Console.ReadLine());
            }

            int[] rslt = TwoSum(nums, target);
            Console.WriteLine("Indices : [{0}, {1}]", rslt[0], rslt[1]);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] rslt = new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=i+1; j<nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        rslt[0] = i;
                        rslt[1] = j;                        
                    }
                }
            }
            return rslt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamCose
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, score1 = 0, score = 0, product = 1, sum1 = 0;
            int[] arr = { 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sum = arr[i] + arr[i + 1];
                if (sum % 2 == 0)
                {
                    score = score + 5;
                }
            }
            Console.WriteLine(score);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                sum1 = arr[i] + arr[i + 1] + arr[i + 2];
                product = arr[i] * arr[i + 1] * arr[i + 2];
                if (sum1 % 2 != 0 && product % 2 == 0)
                {
                    score1 = score1 + 10;
                }
                Console.WriteLine(score1);

                Console.WriteLine(score + score1);

            }
        }
    }
}

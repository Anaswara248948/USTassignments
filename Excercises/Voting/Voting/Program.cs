using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age;
            int vot;
            Console.WriteLine("Enter your age : ");
            age = int.Parse(Console.ReadLine());

            vot = Votes(age);
            Console.WriteLine("Your age is : "+ vot);

        }
        static int Votes(int ages)
        {
            if(ages>=18)
            {
                Console.WriteLine("You are eligible for voting");
                return ages;
            }
            else
            {
                Console.WriteLine("Your age is less than 18, So You are not eligible for voting.");
                return ages;
            }
        }
    }
}

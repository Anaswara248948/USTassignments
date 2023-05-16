using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no : ");
            int n=int.Parse(Console.ReadLine());
            bool rslt = IsPalindrome(n);

            if (rslt == true)
                Console.WriteLine("Number is palindrome");
            else
                Console.WriteLine("Number not a palindrome");
        }

        public static bool IsPalindrome(int n)
        {
            bool rslt;
            int rev = 0, rem, temp;
            temp = n;
            while(n>0)
            {
                rem=n%10;
                rev = rev * 10 + rem;
                n= n/10;
            }

            if(rev==temp)
                rslt= true;
            else
                rslt= false;

            return rslt;
        }
    }
}

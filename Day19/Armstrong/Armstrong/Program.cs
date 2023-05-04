using System;

namespace Armstrong
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rem, rev = 0;
            Console.WriteLine("Enter a 3 digit no : ");
            int n=int.Parse(Console.ReadLine());

            int temp = n;

            while(n > 0)
            {
                rem = n % 10;
                rev = rev + (rem*rem*rem);
                n = n / 10;
            }

            if (temp == rev)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

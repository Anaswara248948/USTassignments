using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no : ");
            int n=int.Parse(Console.ReadLine());
            if(n % 2 != 0 )
            {
                Console.WriteLine("Weired");
            }
            else if(n % 2 == 0 && n >=5 && n <= 2)
            {
                Console.WriteLine("Not Weired");
            }
            else if(n % 2 == 0 && n <= 20 && n >=6)
            {
                Console.WriteLine("Weired");
            }
            else
            {
                Console.WriteLine("Not Weired");
            }
        }
    }
}

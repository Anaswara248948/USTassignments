using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "dotnet programming";
            foreach (var c in str)
            {
                 Console.WriteLine(c);
            }

            //str.Replace(' ', '$');
            //Console.WriteLine(str);
        }
    }
}

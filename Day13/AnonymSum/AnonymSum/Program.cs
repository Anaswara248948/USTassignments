using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace AnonymSum
{
    public delegate int Sums(int x, int y);
    public class Program
    {
        public static void Main(string[] args)
        {
            int s = 0;
            Sums sum = delegate(int n, int m)
            {
                return n + m;
            };
            s = sum(5, 10);
            Console.WriteLine(s);
        }
    }
}

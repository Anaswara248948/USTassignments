using System;


namespace AnonymousmthdDemo
{
    delegate void CountIt();
   public class Program
    {
        static void Main(string[] args)
        {
            CountIt count = delegate
            {
                for (int i = 1; i <= 10; i++)
                      Console.WriteLine(i);                
            };
            //count++;
        }
    }
}

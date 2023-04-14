using System;
using System.Collections.Generic;

namespace MailExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 2; j++)
            {
                Console.WriteLine($"Enter Mail {j} Detail:", j+1);
                string input = Console.ReadLine();
                string[] i = input.Split(',');
                Mail m1 = new Mail(int.Parse(i[0]), i[1], i[2], i[3], i[4], DateTime.Parse(i[5]), double.Parse(i[6]));

                string[] inputs = input.Split(',');

                Console.WriteLine(m1);
            }
        }
    }
}

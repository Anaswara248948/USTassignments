using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int amt;
            int tot = 0;
            Console.WriteLine("Enter the amount : ");
            amt=int.Parse(Console.ReadLine());

            int ttt = amt / 2000;
            Console.WriteLine("The no of 2000 notes : " + ttt);
            amt = amt % 2000;

            int fff = amt / 500;
            Console.WriteLine("The no of 500 notes : " + fff);
            amt = amt % 500;

            int tt = amt / 200;
            Console.WriteLine("The no of 200 notes : " + tt);
            amt = amt % 200;

            int h = amt / 100;
            Console.WriteLine("The no of 100 notes : " + h);
            amt = amt % 100;

            int f = amt / 50;
            Console.WriteLine("The no of 50 notes : " + f);
            amt = amt % 50;

            int t = amt / 20;
            Console.WriteLine("The no of 20 notes : " + t);
            amt = amt % 20;

            int tens = amt / 10;
            Console.WriteLine("The no of 10 notes : " + tens);
            amt = amt % 10;

            int fives = amt / 5;
            Console.WriteLine("The no of 5 notes : " + fives);
            amt = amt % 5;

            int twos = amt / 2;
            Console.WriteLine("The no of 2 notes : " + twos);
            amt = amt % 2;

            int ones = amt / 1;
            Console.WriteLine("The no of 1 notes : " + ones);
            amt = amt % 1;

            tot = ttt + fff + tt + h + f + t + tens + fives + twos + ones;
            Console.WriteLine("The minimum no of notes required is : " + tot);


        }
    }
}

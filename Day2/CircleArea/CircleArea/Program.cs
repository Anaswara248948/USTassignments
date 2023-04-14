using System;


namespace CircleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hellooo World!!!!!!");

            
            double pi = 3.14;
            Console.WriteLine("Enter radius of circle : ");
            double r = double.Parse(Console.ReadLine());

            //calculate the area
            //double area = pi * r * r;
            //Console.WriteLine("The area of circle is "+ area);
            //Console.WriteLine($"The area of circle is {area}" );

            double area = 0.0;
            area = calcArea(r);
            Console.WriteLine("The area of circle is " + area);
        }
        static double calcArea(double rr)
        {
            return 3.14 * rr * rr;
        }
    }
}

using System;
 public class Program
{
    static void Main(string[] args)
    {
        Figure fig1 = new Circle();
        fig1.dim = 3;
        Console.WriteLine("Area of Circle : " + fig1.Area());
        Console.WriteLine("Perimeter of Circle : " + fig1.Perimeter());

        Figure fig2 = new Square();
        fig2.dim = 3;
        Console.WriteLine("Area of Square : " + fig2.Area());
        Console.WriteLine("Perimeter of Square : " + fig2.Perimeter());

    }
}


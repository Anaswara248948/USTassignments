using System;
class Program
{
    static void Main(string[] args)
    {
        IFigure fig = null;
        Console.WriteLine("Enter 'C' for Circle or 'S for' Square");
        string ch = Console.ReadLine();
        if (ch == "C")
        {
            Console.WriteLine("Circle");
            fig = new Circle();
        }
        else if (ch == "S")
        {
            Console.WriteLine("Square");
            fig = new Square();
        }
        fig.Dimension = 10;
        Console.WriteLine("Area : " + fig.Area());
        Console.WriteLine("Perimeter : " +fig.Perimeter());
    }
}


using System;

public class Shapes
{
    public virtual void drawShape()
    {
        Console.WriteLine("Draw Shapes");
    }
}

public class Circle : Shapes
{
    public override void drawShape()
    {
        Console.WriteLine("Draw Circle");
    }
}

public class Rectangle : Shapes
{
    public override void drawShape()
    {
        Console.WriteLine("Draw Rectangle");
    }
}


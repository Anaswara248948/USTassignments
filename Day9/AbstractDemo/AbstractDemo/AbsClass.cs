using System;

abstract class Figure
{
        public int dim;
        public abstract double Area();
        public abstract double Perimeter();
}

class Circle : Figure
{
    public override double Area()
    {
        return Math.PI * dim * dim;
    }

    public override double Perimeter()
    {
        return Math.PI * dim * 2;
    }
}

class Square : Figure
{
    public override double Area()
    {
        return dim * dim;
    }

    public override double Perimeter()
    {
        return 4 * dim;
    }
}

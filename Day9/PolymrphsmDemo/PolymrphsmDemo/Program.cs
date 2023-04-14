using System;

namespace PolymrphsmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes s1 = new Shapes();
            s1.drawShape();

            Circle c1 = new Circle();
            c1.drawShape();

            Rectangle r1 = new Rectangle();
            r1.drawShape();

            Shapes s2 = new Circle();
            s2.drawShape();

            Shapes s3 = new Rectangle();
            s3.drawShape();

            //Array of references of base class referencing 
            //Derived class object(UPCASTING)

            Shapes[] p =
            {
                new Circle(),       
                new Rectangle(),

            };

            for(int i=0; i<p.Length; i++)
            { 
                p[i].drawShape(); 
            }




            Shapes t = null;
            Console.WriteLine("Enter Shape : ");
            string shape=Console.ReadLine();
            //if(shape.ToLower()==)
        }
    }
}

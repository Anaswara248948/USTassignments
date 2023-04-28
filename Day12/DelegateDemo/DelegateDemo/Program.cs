using System;


namespace DelegateDemo
{
    public class Program
    {
        static void Add(int i,int j)
        {
            Console.WriteLine("Sum : "+(i+j));
        }
        static void Sub(int i,int j)
        {
            Console.WriteLine("Sub : " + (i - j));
        }

        public delegate void reftomethod(int i, int j);
        static void Main(string[] args)
        {
            //Add(10, 20);
            //reftomethod r1 = Add;
            //r1(10, 20);
            //reftomethod r2 = Sub;
            //r2(10, 20);
            //r2.Invoke(20, 30);

            //Multicast Delegate
            reftomethod multicast = Add;
            multicast += Sub;
            multicast(20, 10);

            Console.WriteLine("After Removing Sub");
            multicast -= Sub;
            multicast(20, 10);

        }
    }
}

using System;

namespace Telephone
{
    class Telephone
    {
        protected string phonetype;

        public void Ring(string pt)
        {
            pt = phonetype;
            Console.WriteLine("Ringing the "+pt);
        }
        public Telephone()
        { }
    }

    class ElectronicPhone : Telephone
    {
        public ElectronicPhone()
        {
            phonetype = "Digital";
        }

        public void Run()
        {
            base.Ring(phonetype);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone e1=new ElectronicPhone();
            e1.Run();
        }
    }
}

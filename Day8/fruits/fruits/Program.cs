using System;

namespace fruits
{
    class fruits
    {
        private int _no;
        public int No
        {
            get { return _no; }
            set { _no = value; }
        }

        protected string _name;
        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != null)
                    _name = value;
                else
                    Console.WriteLine("Invalid input");
            }
        }

        public fruits(int no, string name)
        {
            No= no;
            Name= name;
        }

        public void print()
        {
            Console.WriteLine("No : " + No +"\n"+ "Name : " + Name);
        }

        public fruits()
        {   }

    }

    class orange : fruits
    {
        private string origin;
        public string[] org = { "Himachal Pradesh", "Maharashtra", "Telugana" };
        public string Origin
        {
            get { return origin; }
            set
            {
                if (Array.BinarySearch(org, value) >= 0)
                    origin = value;
                else
                    Console.WriteLine("Invalid Origin");
            }

        }        
        public orange(int no, string name, string org) : base(no, name)
        {
            org = origin;
        }

        public new void print()
        {
            base.print();
            Console.WriteLine("The origin is" + origin);
        }

        public orange()
        {     }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            orange Obj1= new orange(2,"Orange","Maharashtra");
            Obj1.print();

        }
    }
}

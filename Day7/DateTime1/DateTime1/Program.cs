using System;

namespace DateTime1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //gives current date and time
            Console.WriteLine(DateTime.Now);
                        
            //gives default value
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);

            //gives year, month, day order
            DateTime dt2 = new DateTime(2023, 4, 11);
            Console.WriteLine(dt2);

            //gives year, month, day, hour, min, seconds order
            DateTime dt3 = new DateTime(2023, 4, 11, 7, 12, 26);
            Console.WriteLine(dt3);

        }
    }
}

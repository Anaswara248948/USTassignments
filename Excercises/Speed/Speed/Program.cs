using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    public class Program
    {
        static void Main(string[] args)
        {

            float dis,hr,min,sec;
            float timesec, kph, mph;
            
            Console.WriteLine("Enter the distance in meters : ");
            dis=float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in hours : ");
            hr = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in minutes : ");
            min = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time in seconds : ");
            sec = float.Parse(Console.ReadLine());

            timesec = (hr * 3600) + (min * 60) + sec;
            
            kph = (dis / 1000.0f) / (timesec / 3600.0f);
            mph = kph / 1.609f;

            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);

        }
    }
}

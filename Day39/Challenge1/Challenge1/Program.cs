using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total;
            Console.WriteLine("Enter the student type : ");
            string type=Console.ReadLine();
            Console.WriteLine("Enter tuition fee : ");
            float tfee= float.Parse(Console.ReadLine());
            Math.Round(tfee, 2);
            Console.WriteLine("Enter bus fee : ");
            float bfee = float.Parse(Console.ReadLine());
            Math.Round(bfee,2);
            Console.WriteLine("Enter hostel fee : ");
            float hfee = float.Parse(Console.ReadLine());
            Math.Round(hfee, 2);

            if (type== "MSDS")
            {
                total = tfee+bfee;
                Console.WriteLine("The fees to be paid by the student is {0}",total);
            }
            else if(type == "MSH")
            {
                total = tfee+hfee;
                Console.WriteLine("The fees to be paid by the student is {0}", total);
            }
            else if(type== "MGSDS")
            {
                double t = bfee + tfee;
                total = 1.50 * t ;
                Console.WriteLine("The fees to be paid by the student is {0}", total);
            }
            else
            {
                double t = hfee + tfee;
                total = 1.50 * t;
                Console.WriteLine("The fees to be paid by the student is {0}", total);
            }
        }
    }
}

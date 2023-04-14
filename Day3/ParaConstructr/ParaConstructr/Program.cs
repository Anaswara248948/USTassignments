using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaConstructr
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter id and name : ");
            int eid=int.Parse(Console.ReadLine());
            string ename=Console.ReadLine();
            Emp e1 = new Emp(eid,ename);
           // e1.display();
            Console.WriteLine(e1.eid);
            Console.WriteLine(e1.ename);

        }
    }
}

using System;
using System.Collections.Generic;

namespace CarPoolingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Member> li = new List<Member>();
            //for (int j = 1; j <= 2; j++)
            //{
            //    Console.WriteLine($"Enter Mail {j} Detail:", j + 1);
            //    string input = Console.ReadLine();
            //    string[] ip = input.Split(',');
            //    Member m1 = new Member(long.Parse(ip[0]), ip[1], ip[2], ip[3], ip[4], ip[5], DateTime.Parse(ip[6]), DateTime.Parse(ip[7]));

            //    string[] inputs = input.Split(',');

            //    //Console.WriteLine(m1);
            //    li.Add(m1);
            //}


            Console.WriteLine("Member 1");
            Console.WriteLine("Id : ");
            long id=long.Parse(Console.ReadLine());
            Console.WriteLine("first name : ");
            string firstname=Console.ReadLine();
            Console.WriteLine("last name : ");
            string lastname=Console.ReadLine();
            Console.WriteLine("email : ");
            string email=Console.ReadLine();
            Console.WriteLine("Contact number : ");
            string contactnumber=Console.ReadLine();
            Console.WriteLine("Liscense number : ");
            string liscencenumber=Console.ReadLine();
            Console.WriteLine("Liscence start date: ");
            DateTime liscencestartdate=DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Liscence end date: ");
            DateTime liscenceenddate = DateTime.Parse(Console.ReadLine());

            Member m1 = new Member(id,firstname,lastname,email,contactnumber,liscencenumber,liscencestartdate,liscenceenddate);


            Console.WriteLine("Member 2");
            Console.WriteLine("Id : ");
            long id1 = long.Parse(Console.ReadLine());
            Console.WriteLine("first name : ");
            string firstname1 = Console.ReadLine();
            Console.WriteLine("last name : ");
            string lastname1 = Console.ReadLine();
            Console.WriteLine("email : ");
            string email1 = Console.ReadLine();
            Console.WriteLine("Contact number : ");
            string contactnumber1 = Console.ReadLine();
            Console.WriteLine("Liscense number : ");
            string liscencenumber1 = Console.ReadLine();
            Console.WriteLine("Liscence start date: ");
            DateTime liscencestartdate1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Liscence end date: ");
            DateTime liscenceenddate1 = DateTime.Parse(Console.ReadLine());

            Member m2 = new Member(id1, firstname1, lastname1, email1, contactnumber1, liscencenumber1, liscencestartdate1, liscenceenddate1);


            li.Add(m1);
            li.Add(m2);

            foreach (var item in li)
            {
                int j = 1;
                Console.WriteLine("Member {0}",j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Member 1 and Member 2 are same");
            }
            else
            {
                Console.WriteLine("Member 1 and Member 2 are not same");
            }
        }
            public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    internal class Prog
    {
        static void Main(string[] args)
        {

            int ch;
            Account1 a = null;

            do
            {

                Console.WriteLine("**********BANK ACCOUNT***********");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Display Account Information");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Withdraw");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter your choice : ");
                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter your Account Id : ");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Name : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter opening Balance : ");
                        decimal balance = decimal.Parse(Console.ReadLine());

                        //Console.WriteLine("Enter Salary : ");
                        //decimal _salary = decimal.Parse(Console.ReadLine());

                        a = new Account1();
                        a.createAccount(id, name, balance);

                        break;

                    case 2:
                        if (a != null)
                        {
                            a.Display();
                        }
                        else
                        {
                            Console.WriteLine("*****Please create ACCOUNT first******");
                        }

                        break;

                    case 3:
                        if (a != null)
                        {
                            a.Deposit();
                        }
                        else
                        {
                            Console.WriteLine("*****Please create ACCOUNT first******");
                        }

                        break;

                    case 4:
                        if (a != null)
                        {
                            a.Withdraw();
                        }
                        else
                        {
                            Console.WriteLine("*****Please create ACCOUNT first******");
                        }

                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }

            } while (ch != 0);

        }
    }
}

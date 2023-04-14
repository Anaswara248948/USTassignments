using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int ch;
            Account a = null;

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
                ch=int.Parse(Console.ReadLine());   

                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter your Account Id : ");
                        int Id=int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your Name : ");
                        string Name=Console.ReadLine();
                        Console.WriteLine("Enter opening Balance : ");
                        decimal Balance=decimal.Parse(Console.ReadLine());

                        a= new Account();
                        a.createAccount(Id, Name, Balance);

                        break;

                    case 2:
                        if(a!=null)
                        {
                            a.Display();
                        }
                        else
                        {
                            Console.WriteLine("*****Please create ACCOUNT first******" );
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

            } while (ch !=0);

        }
    }
}

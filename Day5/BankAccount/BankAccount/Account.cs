using System;

namespace BankAccount
{
    public class Account
    {

        public int Id;
        public string Name;
        public decimal Balance;
        public void createAccount(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public void Display()
        {
            Console.WriteLine("The Account id : "+Id);
            Console.WriteLine("The Name : " + Name);
            Console.WriteLine("Balance : " + Balance);
        }

        public void Deposit()
        {
            Console.WriteLine("Enter Deposit Amount");
            decimal amt=decimal.Parse(Console.ReadLine());
            Balance += amt;
            Console.WriteLine("Total Balance : "+Balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter Withdraw Amount");
            decimal amt1 = decimal.Parse(Console.ReadLine());
            if (Balance - amt1 > 500)
            {
                Balance -= amt1;
                Console.WriteLine("Total Balance : " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}
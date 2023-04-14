using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcc
{
    public class Account1
    {

        public int Id;
        //public int Id
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 15)
                    throw new ApplicationException("The name is too big...!");
                _name = value;
            }
        }

        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }


        ////PARTIAL ACCESSIBILITY
        //private decimal _salary;
        //public decimal Salary
        //{
        //    get { return _salary; }
        //}



        //public int Id;
        //public string Name;
        //public decimal Balance;
        public void createAccount(int _id, string _name, decimal _balance)
        {
            Id = _id;
            Name = _name;
            Balance = _balance;
        }

        //public void Display()
        //{
        //    Console.WriteLine("The Account id : " + Id);
        //    Console.WriteLine("The Name : " + Name);
        //    Console.WriteLine("Balance : " + Balance);

        //    //Console.WriteLine("Salary : " + Salary);
        //}


        //OVERRIDE METHOD - ToString is a method of OBJECT CLASS to display values without any methods
        
        public override string ToString()
        {
            return $"The Account Id : {Id} \n Name : {Name} \n Balance : {Balance}";
        }


        public void Deposit()
        {
            Console.WriteLine("Enter Deposit Amount");
            decimal amt = decimal.Parse(Console.ReadLine());
            Balance += amt;
            Console.WriteLine("Total Balance : " + Balance);
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

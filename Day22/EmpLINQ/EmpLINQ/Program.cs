using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLINQ
{
    public class Employee
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _city;
        public string City { get { return _city; } set { _city = value; } }

        public Employee(string name, string city)
        {
            Name = name;
            City = city;
        }

        public Employee()
        {

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li1 = new List<Employee>();
            li1.Add(new Employee("Anu","Tdpa"));
            li1.Add(new Employee("Rahul","Ernklm"));
            li1.Add(new Employee("Ramya","Trivandrum"));
            li1.Add(new Employee("Manu","Tdpa"));
            li1.Add(new Employee("Sachin","Ernklm"));
            li1.Add(new Employee("Veena","Kozhikode"));

            var eQuery =
                from Employee emp in li1
                orderby emp.City
                group emp by emp.City;

            foreach (var e in eQuery)
            {
                Console.WriteLine("Employee with " +e.Key+" City : ");
                foreach (var em in e)
                {
                    Console.WriteLine(" "+em.Name);
                }
            }
        }   
    }
}

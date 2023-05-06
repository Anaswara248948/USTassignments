using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDemo1
{
    internal class Program
    {
        static void Main(string[] args)

            // DB FIRST APPROACH
        {
            using (var context = new BankDBEntities())
            {

                //INSERT DATA

                //var emp = new employee()
                //{
                //    eid = 1001,
                //    ename = "Abdul",
                //    city = "Hyderabad",
                //    salary = 65000
                //};
                //context.employees.Add(emp);
                //context.SaveChanges();

                //UPDATE DATA
                using (var context1 = new BankDBEntities())
                {
                    var emp1 = context1.employees.First<employee>();
                    emp1.ename = "Steve";
                    context1.SaveChanges();
                }
            }
        }
    }
}

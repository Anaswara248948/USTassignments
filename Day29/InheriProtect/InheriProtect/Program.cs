using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriProtect
{
    class Animal
    {
        protected string name="luca";
        public void display()
        {
            Console.WriteLine(name);
        }
    }
    class dog : Animal
    {
        static void Main(string[] args)
        {

            dog d = new dog();
            d.display();
        }
        
    }
    
}

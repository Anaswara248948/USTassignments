﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The even numbers b/w 1 and 100");

            for (int i=1; i<=100; i++)
            {
                if(i%2==0)
                {              
                    Console.WriteLine(i);
                }
            }

        }
    }
}

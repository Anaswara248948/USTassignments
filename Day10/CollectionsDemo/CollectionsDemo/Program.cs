using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace CollectionsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList l1 = new ArrayList();
            l1.Add(100);
            l1.Add("Anu");
            l1.Add(45.4f);
            l1.Add(201);
            foreach(object obj1 in l1)
            {
                Console.WriteLine(obj1);
            }
            Console.WriteLine("-----------------------");

            l1.Insert(1, "added");

            foreach (object obj1 in l1)
            {
                Console.WriteLine(obj1);
            }

            Console.WriteLine("-----------------------");

            l1.RemoveAt(1);

            foreach (object obj1 in l1)
            {
                Console.WriteLine(obj1);
            }
        }
    }
}

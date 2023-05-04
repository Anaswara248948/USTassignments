using System;
using System.Collections;
using System.Collections.Generic;


namespace DictDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> s = new SortedList<string, string>();
            // String is given for type safety
            s.Add("Maharashtra", "Mumbai");
            s.Add("Karnataka", "Banglore");
            s.Add("TamilNadu", "Chennai");

            Console.WriteLine("Sorted Keys in list is : ");
            foreach (var item in s.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Sorted Values in list is : ");
            foreach (var item in s.Values)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine("Key at 3rd index : " + s.GetKey(3));

        }       
    }
}
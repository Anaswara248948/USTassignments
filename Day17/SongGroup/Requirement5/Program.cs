using System;
using System.Collections.Generic;

namespace Requirement5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> list1 = new List<Song>();
            Console.WriteLine("Enter no of songs : ");
            int n=int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] str = Console.ReadLine().Split(',');                
                int nd = int.Parse(str[4]);
                DateTime dt = DateTime.ParseExact(str[5], "dd-MM-yyyy", null);
                Song s1 = new Song(str[0], str[1], str[2], double.Parse(str[3]), nd, dt);
                list1.Add(s1);
            }

            
            SortedDictionary<string, int> sd= Song.CalculateTypeCount(list1);
            Console.WriteLine("The sorted dictionary is : ");
            Console.WriteLine("SongName\tCount");
            foreach(var s in sd)
            {
                Console.WriteLine("{0} {1,15}",s.Key, s.Value);
            }
        }
    }
}

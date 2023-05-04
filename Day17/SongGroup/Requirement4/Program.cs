using System;
using System.Collections.Generic;


namespace Requirement4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name\t Artist\t SongType\t Rating\t NoOfDownloads\t DateDownloaded");
            List<Song> ls = SongRepo.GetAllSongs();
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();


            ls.Sort(new RatingComparer());

            Console.WriteLine("sorted list");

            Console.WriteLine("Name\t Artist\t SongType\t Rating\t No.Of Downloads\t Date of Download");

            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();



            ls.Sort(new PopularityComparer());

            Console.WriteLine("sorted list");

            Console.WriteLine("Name\t Artist\t SongType\t Rating\t No.Of Downloads\t Date of Download");

            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

        }
    }
}

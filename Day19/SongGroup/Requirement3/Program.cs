using System;
using System.Collections.Generic;

namespace Requirement3
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = SongRepo.GetAllSongs();
            foreach (Song s in ls)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("Enter Song Type : ");
            string type=Console.ReadLine();

            //using this the findsong must be static
            //List<Song> ls1 = SongBO.FindSong(ls, type);

            SongBO s1 = new SongBO(ls,type);
            List<Song> songtype = s1.FindSong(ls,type);

            Console.WriteLine("SongName\tSongType");
            foreach (Song s in songtype)
            {
                Console.Write(s.Name+"\t");
                Console.WriteLine(s.SongType);
            }



            Console.WriteLine("Enter Date Downloaded : ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());

            SongBO s2 = new SongBO(ls, date1);
            List<Song> songtype1 = s2.FindSong(ls, date1);

            Console.WriteLine("SongName\tDateDownloaded");
            foreach (Song s in songtype1)
            {
                Console.Write(s.Name + "\t");
                Console.WriteLine(s.DateDownloaded);
            }



            Console.WriteLine("Enter Song Rating : ");
            Double rating = Double.Parse(Console.ReadLine());

            SongBO s3 = new SongBO(ls, rating);
            List<Song> songtype2 = s3.FindSong(ls, rating);

            Console.WriteLine("SongName\tRating");
            foreach (Song s in songtype2)
            {
                Console.Write(s.Name + "\t");
                Console.WriteLine(s.Rating);
            }

        }
    }
}

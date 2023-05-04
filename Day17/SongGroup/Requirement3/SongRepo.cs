using System;
using System.Collections.Generic;

namespace Requirement3
{
    public class SongRepo
    {
        static List<Song> songs = new List<Song>()
        {
            new Song("Shape of You","Edsheeram","POP",4.8,12000,DateTime.Parse("12-10-2017")),
            new Song("Perfect","Edsheeram","POP",4.5,12000,DateTime.Parse("04-05-2016")),
            new Song("Mercy","Shawn","JAZZ",4.5,214500,DateTime.Parse("04-05-2016")),
            new Song("Something just like this","Coldplay","Melody",4.5,105421,DateTime.Parse("05-07-1997"))
            
        };

        public static List<Song> GetAllSongs()
        {
            return songs;
        }

    }
}

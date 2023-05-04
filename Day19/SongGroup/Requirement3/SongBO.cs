using System;
using System.Collections.Generic;

namespace Requirement3
{
    public class SongBO
    {
        private List<Song> ls;
        private string type;
        private DateTime date1;

        public SongBO(List<Song> ls, string type)
        {
            this.ls = ls;
            this.type = type;
        }

        public SongBO(List<Song> ls, DateTime date1)
        {
            this.ls = ls;
            this.date1 = date1;
        }

        public SongBO(List<Song> ls, double rating)
        {
            this.ls = ls;
            Rating = rating;
        }

        public double Rating { get; }

        //static
        public List<Song> FindSong(List<Song> songList, string type)
        {
            List<Song> list1 = new List<Song>();

            foreach (Song s in songList)
            {
                if (s.SongType == type)
                {
                    list1.Add(s);
                }
            }
            return list1;

        }

        public List<Song> FindSong(List<Song> songList, DateTime date1)
        {
            List<Song> list2 = new List<Song>();

            foreach (Song s in songList)
            {
                if (s.DateDownloaded == date1)
                {
                    list2.Add(s);
                }
            }
            return list2;
        }




            public List<Song> FindSong(List<Song> songList, double rating)
            {
            List<Song> list3 = new List<Song>();

            foreach (Song s in songList)
            {
                if (s.Rating == rating)
                {
                    list3.Add(s);
                }
            }
            return list3;
        }



      
    }
}

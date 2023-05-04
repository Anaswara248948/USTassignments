using System;
using System.Collections.Generic;


namespace Requirement4
{
    public class RatingComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            return y.Rating.CompareTo(x.Rating);
        }

        
    }
}

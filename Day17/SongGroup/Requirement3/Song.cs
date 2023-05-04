﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Requirement3
{
    public class Song
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        private string _artist;
        public string Artist { get { return _artist;} set { _artist = value; } }

        private string _songType;
        public string SongType { get { return _songType; } set { _songType = value; } }

        private double _rating;
        public double Rating { get { return _rating; } set { _rating = value; } }

        private int _numberOfDownloads;
        public int NumberOfDownloads { get { return _numberOfDownloads; } set { _numberOfDownloads = value; } }

        private DateTime _dateDownloaded;
        public DateTime DateDownloaded { get { return _dateDownloaded; } set { _dateDownloaded = value;} }


        public Song()
        { }

        public Song(string _name, string _artist, string _songType, double _rating, int _numberOfDownloads, DateTime _dateDownloaded)
        {
            Name = _name;   
            Artist = _artist;
            SongType = _songType;
            Rating = _rating;
            NumberOfDownloads = _numberOfDownloads;
            DateDownloaded = _dateDownloaded;
        }

        public override string ToString()

        {

            return String.Format($"Name: {_name}\nArtist: {_artist}\nSongType: {_songType}\nRating: {_rating}\nNoOfDownloads: {_numberOfDownloads}\nDateDownloaded: {_dateDownloaded}");

        }

    }
}

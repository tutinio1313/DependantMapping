using System;
using Patron_Model;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Patron
{
    public static class Populate
    {
        private static string AlbumJsonPath = "Database/Album.json";
        private static string TrackJsonPath = "Database/Track.json";
        private static List<Album> albums = new();
        private static List<TempTrack> tracks = new();

        public static void AddAlbum()
        {
            albums = JsonConvert.DeserializeObject<List<Album>>(File.ReadAllText(AlbumJsonPath));

            foreach (TempTrack track in tracks)
            {
                albums[track.AlbumID - 1].AddTrack(track);
            }
        }

        public static void AddTrack()
        {
            tracks = JsonConvert.DeserializeObject<List<TempTrack>>(File.ReadAllText(TrackJsonPath));
        }

        public static List<Album> GetAlbums() => albums;
        public static List<TempTrack> GetTracks() => tracks;

        /*public static void test()
        {
            foreach (Album album in albums)
            {
                Console.Write("\n" + album.Title);
                Console.Write(" by " + album.Artist + "\n");

                foreach (Track track in album.Tracks)
                {
                    Console.WriteLine("     " + track.Title);
                }
            }
        }*/

    }
}
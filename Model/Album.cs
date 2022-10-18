using System;
using System.Collections.Generic;

namespace Patron_Model
{
    public class Album
    {
        public string id{ get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Artist { get; set; } = String.Empty;
        public List<Track> Tracks { get;} = new();

        public void RemoveTrack(Track track)
        {
            Tracks.Remove(track);
        }

        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }   
    }
}
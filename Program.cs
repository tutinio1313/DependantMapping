using System;

namespace Patron
{
    public static class Program
    {
        static void Main()
        {
            Populate.AddTrack();
            Populate.AddAlbum();

            Populate.test();

        }
    }
}
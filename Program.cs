using System;
using System.Collections.Generic;
using Patron_Model;
using Patron_Database;
namespace Patron
{
    public class Program
    {

        static void Main()
        {

            using Context context = new();

            //En las funciones que siguen se cargan instancias de las clases Album y Track.
            Populate.AddTrack();
            Populate.AddAlbum();

            //Populate.Test();

            Add(context);

        }

        static void Add(Context context)
        {
            Album album = new();
            Track track = new();

            System.Console.WriteLine("Escriba el nombre del album");
            album.Title = Console.ReadLine();

            System.Console.WriteLine("Escriba el nombre del artista");
            album.Artist = Console.ReadLine();
            album.id = Convert.ToString(Populate.GetAlbums().Count + 1);

            bool loop = false;
            do
            {                
                
                track.TrackID = Populate.GetTracks().Count +1;

                System.Console.WriteLine("Escriba el nombre de la canción");
                track.Title = Console.ReadLine();

                System.Console.WriteLine("Escriba la duración de la canción (minutos:segundos)");
                track.length =Console.ReadLine();

                album.AddTrack(track);

                string breakCondition = "a";
                do
                {
                    System.Console.WriteLine("¿Deseas agregar otra canción?");
                    breakCondition = Console.ReadLine();
                } while (breakCondition != "si" && breakCondition != "no");

                if(breakCondition.ToLower() == "no")
                {
                    loop = true;
                }
                                                
            } while (loop != true);


            if (context.albums.Find(album.Artist) == null)
            {
                context.albums.Add(album);
            }


            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AlbumAndPhoto.Fetchers;
using AlbumAndPhoto.Models;
using AlbumAndPhoto.Repository;

namespace AlbumAndPhoto
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AlbumAndPhotoFetchers albumAndPhotoFetchers = new AlbumAndPhotoFetchers();
            AlbumAndPhotoRepository albumAndPhotoRepository = new AlbumAndPhotoRepository();
            List<Album> albums = await albumAndPhotoFetchers.FetchAlbum();
            List<Photo> photos = new List<Photo>();
            for (int i = 0; i < albums.Count; i+=5)
            {
                for (int j = 0; j < 5 && j < albums.Count; j ++)
                {
                    photos.AddRange(await albumAndPhotoFetchers.FetchPhoto(albums[i + j].Id));
                }
                Console.WriteLine("Got " + i + " photos");
                Thread.Sleep(5000);
            }
            albumAndPhotoRepository.Albums.AddRange(albums);
            albumAndPhotoRepository.Photos.AddRange(photos);
            albumAndPhotoRepository.SaveChanges();

        }

    }
}

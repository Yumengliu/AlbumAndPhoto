using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using AlbumAndPhoto.Models;

namespace AlbumAndPhoto.Fetchers
{
    public class AlbumAndPhotoFetchers
    {
        private readonly HttpClient httpClient; 
        public AlbumAndPhotoFetchers()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<Album>> FetchAlbum()
        {
            Task<string> response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/albums");
            string jsonString = await response;
            return JsonSerializer.Deserialize<List<Album>>(jsonString);
        }

        public async Task<List<Photo>> FetchPhoto(int Id)
        {

            Task<string> response = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/photos?albumId=" + Id);
            string jsonString = await response;
            return JsonSerializer.Deserialize<List<Photo>>(jsonString);
        }
    }
}

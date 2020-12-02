using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AlbumAndPhoto.Models
{
    public class Photo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("albumId")]
        public int AlbumId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        public Album Album { get; set; }

        public Photo()
        {
        }
    }
}

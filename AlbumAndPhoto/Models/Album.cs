using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AlbumAndPhoto.Models
{
    public class Album
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        public List<Photo> Photos { get; set; }

        public Album()
        {
        }
    }
}

using System;
using System.Net.Http;
using AlbumAndPhoto.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumAndPhoto.Repository
{
    public class AlbumAndPhotoRepository : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Photo> Photos { get; set; }

        public AlbumAndPhotoRepository()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("server=localhost,1433;database=AlbumAndPhoto;user id=sa;password=YourStrong@Passw0rd");
        }
    }
}

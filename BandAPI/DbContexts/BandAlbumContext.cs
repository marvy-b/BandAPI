using BandAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.DbContexts
{
    public class BandAlbumContext :  DbContext
    {
        public BandAlbumContext(DbContextOptions<BandAlbumContext> options) :
             base (options)
        {
        }

        public DbSet<Band> Bands { get; set; }
        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(new Band()
            {
                Id = Guid.Parse("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4"),
                Name = "Metallic",
                Founded = new DateTime(1980, 1, 1),
                MainGenre = "Rock"
            },
            new Band
            {
                Id = Guid.Parse("4323e0b5-58b4-4e9e-9eff-f35aad529f25"),
                Name = "Fela Kuti & Africa 70",
                Founded = new DateTime(1970),
                MainGenre = "Afrobeat"
            },
            new Band
            {
                Id = Guid.Parse("f17ebd4a-dd77-46fd-95dc-202727da4e64"),
                Name = "The Cavemen",
                Founded = new DateTime(2018),
                MainGenre = "Highlife"
            },
            new Band
            {
                Id = Guid.Parse("9f7522ec-4eec-45e1-8e2e-8887c69933d1"),
                Name = "A-ha",
                Founded = new DateTime(1981, 6, 1),
                MainGenre = "Pop"
            },
            new Band
            {
                Id = Guid.Parse("a8be796f-f2fc-4e1f-a36b-08f60cddc22f"),
                Name = "Oasis",
                Founded = new DateTime(1991, 12, 1),
                MainGenre = "Alternative"
            },
            new Band
            {
                Id = Guid.Parse("873a1ffd-d60f-46bb-ae64-b5a642b0eae2"),
                Name = "Guns N Roses",
                Founded = new DateTime(1985, 2, 1),
                MainGenre = "Rock"
            });

            modelBuilder.Entity<Album>().HasData(
              new Album
              {
                  Id = Guid.Parse("91888f1b-acfd-4749-aaf0-21142fbf4816"),
                  Title = "Master of Puppets",
                  Description = "One of the best heavy metal albums ever",
                  BandId = Guid.Parse("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4")
              },
            new Album
            {
                Id = Guid.Parse("ec8c3f22-1d68-4e98-965a-bd44b18988e5"),
                Title = "Zombie",
                Description = "Amazing Afrobeat album with raw sound",
                BandId = Guid.Parse("4323e0b5-58b4-4e9e-9eff-f35aad529f25")
            },
             new Album
             {
                 Id = Guid.Parse("65fd490c-5dbd-45c9-8a44-5a8efa873024"),
                 Title = "The Roots",
                 Description = "Very groovy album with badass beat",
                 BandId = Guid.Parse("f17ebd4a-dd77-46fd-95dc-202727da4e64")
             },
              new Album
              {
                  Id = Guid.Parse("8ceda5ae-3713-4343-9db5-a4a8a52699b5"),
                  Title = "Hunting Hight and Low",
                  Description = "Awesome Debut album by A-Ha",
                  BandId = Guid.Parse("9f7522ec-4eec-45e1-8e2e-8887c69933d1")
              },
               new Album
               {
                   Id = Guid.Parse("498ee919-d3e8-4ad5-929a-fa4b7c14e18d"),
                   Title = "Be Here Now",
                   Description = "Arguably one of the best albums by Oasis",
                   BandId = Guid.Parse("a8be796f-f2fc-4e1f-a36b-08f60cddc22f")
               },
               new Album
               {
                   Id = Guid.Parse("984c767b-93f8-49c9-a0c9-33089ec7d12a"),
                   Title = "Waterloo",
                   Description = "Great Sound",
                   BandId = Guid.Parse("873a1ffd-d60f-46bb-ae64-b5a642b0eae2")
               });
            base.OnModelCreating(modelBuilder);
        }
    }
}

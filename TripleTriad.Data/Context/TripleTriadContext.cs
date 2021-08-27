using Microsoft.EntityFrameworkCore;
using TripleTriad.Models.Entity;

namespace TripleTriad.Data.Context
{
    class TripleTriadContext : DbContext
    {
        public DbSet<Board> Boards { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Player> Players { get; set; }

        public TripleTriadContext(DbContextOptions<TripleTriadContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                new { Id = 1,  Name = "Dodo",       Points = new int[4] { 2, 4, 4, 3 }},
                new { Id = 2,  Name = "Tonberry",   Points = new int[4] { 2, 2, 2, 7 }},
                new { Id = 3,  Name = "Sabotender", Points = new int[4] { 3, 4, 3, 3 }},
                new { Id = 4,  Name = "Spriggan",   Points = new int[4] { 3, 2, 4, 4 }},
                new { Id = 5,  Name = "Pudding",    Points = new int[4] { 4, 2, 5, 3 }},
                new { Id = 6,  Name = "Bomb",       Points = new int[4] { 4, 3, 3, 3 }},
                new { Id = 7,  Name = "Mandragora", Points = new int[4] { 2, 4, 3, 5 }},
                new { Id = 8,  Name = "Coblyn",     Points = new int[4] { 3, 3, 4, 3 }},
                new { Id = 9,  Name = "Morbol",     Points = new int[4] { 2, 5, 5, 2 }},
                new { Id = 10, Name = "Coeurl",     Points = new int[4] { 2, 4, 4, 3 }},
                new { Id = 11, Name = "Ahriman",    Points = new int[4] { 2, 4, 4, 3 }},
                new { Id = 12, Name = "Goobbue",    Points = new int[4] { 2, 4, 4, 3 }},
                new { Id = 13, Name = "Chocobo",    Points = new int[4] { 2, 4, 4, 3 }},
                new { Id = 14, Name = "Amalj'aa",   Points = new int[4] { 2, 4, 4, 3 }}
            );
        }
    }
}

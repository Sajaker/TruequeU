using TruequeU.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TruequeU.DAO
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        //Constructor que recibe las opciones de conexión a la bd para tener contexto de esta
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //listado de clases -> a tablas en la base de datos
        //Los DB Set nos ayudan a mapear las clases como Entidades
        //Es decir que Entity Framework lee este archivo para tomar del modelo el esquema de las tablas

        public DbSet<User> Users { get; set; }
        public DbSet<Listing> Listings { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ModerationAction> ModerationActions { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Images> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.Messages)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chat>()
            .HasOne(c => c.Buyer)
            .WithMany()
            .HasForeignKey(c => c.BuyerId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.Seller)
                .WithMany()
                .HasForeignKey(c => c.SellerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Favorite>()
                .HasOne(f => f.Listing)
                .WithMany()
                .HasForeignKey(f => f.ListingId)
                .OnDelete(DeleteBehavior.NoAction);

            var users = new List<User>
            {
                new User { Id = Guid.Parse("11111111-1111-1111-1111-111111111111"), Name = "Juan", Program = "Sistemas", Rating = 4.5, IsSuspended = false, IdentityUserId = "user1" },
                new User { Id = Guid.Parse("22222222-2222-2222-2222-222222222222"), Name = "Ana", Program = "Industrial", Rating = 4.2, IsSuspended = false, IdentityUserId = "user2" },
                new User { Id = Guid.Parse("33333333-3333-3333-3333-333333333333"), Name = "Carlos", Program = "Civil", Rating = 3.8, IsSuspended = false, IdentityUserId = "user3" },
                new User { Id = Guid.Parse("44444444-4444-4444-4444-444444444444"), Name = "Laura", Program = "Electrónica", Rating = 4.9, IsSuspended = false, IdentityUserId = "user4" },
                new User { Id = Guid.Parse("55555555-5555-5555-5555-555555555555"), Name = "Pedro", Program = "Mecánica", Rating = 3.5, IsSuspended = false, IdentityUserId = "user5" }
            };
            modelBuilder.Entity<User>().HasData(users);

            var listings = Enumerable.Range(1, 15).Select(i => new Listing
            {
                Id = Guid.Parse($"aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa{i:D2}"),
                Title = $"Producto {i}",
                Description = $"Descripción del producto {i}",
                Category = "Electrónica",
                Condition = "Usado",
                Price = 10000 + i * 1000,
                Location = "Universidad",
                State = "Disponible",
                CreatedAt = new DateTime(2024, 1, 1),
                IsHidden = false,
                UserId = users[i % users.Count].Id
            }).ToList();

            modelBuilder.Entity<Listing>().HasData(listings);

            var images = Enumerable.Range(1, 25).Select(i => new Images
            {
                id = Guid.Parse($"bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb{i:D2}"),
                listing_id = listings[i % listings.Count].Id,
                url = $"https://placeholder.com/img{i}.jpg"
            }).ToList();

            modelBuilder.Entity<Images>().HasData(images);

            var chats = Enumerable.Range(1, 20).Select(i => new Chat
            {
                Id = Guid.Parse($"cccccccc-cccc-cccc-cccc-cccccccccc{i:D2}"),
                ListingId = listings[i % listings.Count].Id,
                BuyerId = users[i % users.Count].Id,
                SellerId = users[(i + 1) % users.Count].Id
            }).ToList();

            modelBuilder.Entity<Chat>().HasData(chats);

            var messages = Enumerable.Range(1, 30).Select(i => new Message
            {
                Id = Guid.Parse($"dddddddd-dddd-dddd-dddd-dddddddddd{i:D2}"),
                ChatId = chats[i % chats.Count].Id,
                SenderId = users[i % users.Count].Id,
                Content = $"Mensaje {i}",
                SentAt = new DateTime(2024, 1, 1)
            }).ToList();

            modelBuilder.Entity<Message>().HasData(messages);

            var reports = Enumerable.Range(1, 10).Select(i => new Report
            {
                Id = Guid.Parse($"eeeeeeee-eeee-eeee-eeee-eeeeeeeeee{i:D2}"),
                ReporterId = users[i % users.Count].Id,
                ReportedUserId = users[(i + 1) % users.Count].Id,
                ListingId = listings[i % listings.Count].Id,
                Reason = "Contenido inapropiado",
                Comment = $"Reporte {i}",
                Status = "Pendiente",
                CreatedAt = new DateTime(2024, 1, 1)
            }).ToList();

            modelBuilder.Entity<Report>().HasData(reports);


        }



    }
}

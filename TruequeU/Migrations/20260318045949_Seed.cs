using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TruequeU.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "IdentityUserId", "IsSuspended", "Name", "Program", "Rating" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "user1", false, "Juan", "Sistemas", 4.5 },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "user2", false, "Ana", "Industrial", 4.2000000000000002 },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "user3", false, "Carlos", "Civil", 3.7999999999999998 },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "user4", false, "Laura", "Electrónica", 4.9000000000000004 },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "user5", false, "Pedro", "Mecánica", 3.5 }
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Category", "Condition", "CreatedAt", "Description", "IsHidden", "Location", "Price", "State", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa01"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 1", false, "Universidad", 11000m, "Disponible", "Producto 1", new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 2", false, "Universidad", 12000m, "Disponible", "Producto 2", new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 3", false, "Universidad", 13000m, "Disponible", "Producto 3", new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 4", false, "Universidad", 14000m, "Disponible", "Producto 4", new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 5", false, "Universidad", 15000m, "Disponible", "Producto 5", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 6", false, "Universidad", 16000m, "Disponible", "Producto 6", new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 7", false, "Universidad", 17000m, "Disponible", "Producto 7", new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 8", false, "Universidad", 18000m, "Disponible", "Producto 8", new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 9", false, "Universidad", 19000m, "Disponible", "Producto 9", new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 10", false, "Universidad", 20000m, "Disponible", "Producto 10", new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 11", false, "Universidad", 21000m, "Disponible", "Producto 11", new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 12", false, "Universidad", 22000m, "Disponible", "Producto 12", new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 13", false, "Universidad", 23000m, "Disponible", "Producto 13", new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 14", false, "Universidad", 24000m, "Disponible", "Producto 14", new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"), "Electrónica", "Usado", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descripción del producto 15", false, "Universidad", 25000m, "Disponible", "Producto 15", new Guid("11111111-1111-1111-1111-111111111111") }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "BuyerId", "ListingId", "SellerId" },
                values: new object[,]
                {
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc01"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc07"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc08"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc09"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc10"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc11"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc12"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc13"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc14"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc15"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa01"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc16"), new Guid("22222222-2222-2222-2222-222222222222"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), new Guid("33333333-3333-3333-3333-333333333333") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc17"), new Guid("33333333-3333-3333-3333-333333333333"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc18"), new Guid("44444444-4444-4444-4444-444444444444"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), new Guid("55555555-5555-5555-5555-555555555555") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc19"), new Guid("55555555-5555-5555-5555-555555555555"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), new Guid("11111111-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc20"), new Guid("11111111-1111-1111-1111-111111111111"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), new Guid("22222222-2222-2222-2222-222222222222") }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "id", "listing_id", "url" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb01"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), "https://placeholder.com/img1.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb02"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), "https://placeholder.com/img2.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb03"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), "https://placeholder.com/img3.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb04"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), "https://placeholder.com/img4.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb05"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), "https://placeholder.com/img5.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb06"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"), "https://placeholder.com/img6.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb07"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"), "https://placeholder.com/img7.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb08"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"), "https://placeholder.com/img8.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb09"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), "https://placeholder.com/img9.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb10"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), "https://placeholder.com/img10.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb11"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"), "https://placeholder.com/img11.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb12"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"), "https://placeholder.com/img12.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb13"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"), "https://placeholder.com/img13.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb14"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"), "https://placeholder.com/img14.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb15"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa01"), "https://placeholder.com/img15.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb16"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), "https://placeholder.com/img16.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb17"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), "https://placeholder.com/img17.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb18"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), "https://placeholder.com/img18.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb19"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), "https://placeholder.com/img19.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb20"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), "https://placeholder.com/img20.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb21"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"), "https://placeholder.com/img21.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb22"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"), "https://placeholder.com/img22.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb23"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"), "https://placeholder.com/img23.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb24"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), "https://placeholder.com/img24.jpg" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb25"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), "https://placeholder.com/img25.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Comment", "CreatedAt", "ListingId", "Reason", "ReportedUserId", "ReporterId", "Status" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee01"), "Reporte 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"), "Contenido inapropiado", new Guid("33333333-3333-3333-3333-333333333333"), new Guid("22222222-2222-2222-2222-222222222222"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee02"), "Reporte 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"), "Contenido inapropiado", new Guid("44444444-4444-4444-4444-444444444444"), new Guid("33333333-3333-3333-3333-333333333333"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee03"), "Reporte 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"), "Contenido inapropiado", new Guid("55555555-5555-5555-5555-555555555555"), new Guid("44444444-4444-4444-4444-444444444444"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee04"), "Reporte 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"), "Contenido inapropiado", new Guid("11111111-1111-1111-1111-111111111111"), new Guid("55555555-5555-5555-5555-555555555555"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee05"), "Reporte 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"), "Contenido inapropiado", new Guid("22222222-2222-2222-2222-222222222222"), new Guid("11111111-1111-1111-1111-111111111111"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee06"), "Reporte 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"), "Contenido inapropiado", new Guid("33333333-3333-3333-3333-333333333333"), new Guid("22222222-2222-2222-2222-222222222222"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee07"), "Reporte 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"), "Contenido inapropiado", new Guid("44444444-4444-4444-4444-444444444444"), new Guid("33333333-3333-3333-3333-333333333333"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee08"), "Reporte 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"), "Contenido inapropiado", new Guid("55555555-5555-5555-5555-555555555555"), new Guid("44444444-4444-4444-4444-444444444444"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee09"), "Reporte 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"), "Contenido inapropiado", new Guid("11111111-1111-1111-1111-111111111111"), new Guid("55555555-5555-5555-5555-555555555555"), "Pendiente" },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee10"), "Reporte 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"), "Contenido inapropiado", new Guid("22222222-2222-2222-2222-222222222222"), new Guid("11111111-1111-1111-1111-111111111111"), "Pendiente" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "ChatId", "Content", "SenderId", "SentAt" },
                values: new object[,]
                {
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd01"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"), "Mensaje 1", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd02"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"), "Mensaje 2", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"), "Mensaje 3", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"), "Mensaje 4", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"), "Mensaje 5", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc07"), "Mensaje 6", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc08"), "Mensaje 7", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc09"), "Mensaje 8", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc10"), "Mensaje 9", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc11"), "Mensaje 10", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc12"), "Mensaje 11", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc13"), "Mensaje 12", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc14"), "Mensaje 13", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc15"), "Mensaje 14", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc16"), "Mensaje 15", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd16"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc17"), "Mensaje 16", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd17"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc18"), "Mensaje 17", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd18"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc19"), "Mensaje 18", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd19"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc20"), "Mensaje 19", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd20"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc01"), "Mensaje 20", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd21"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"), "Mensaje 21", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd22"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"), "Mensaje 22", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd23"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"), "Mensaje 23", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd24"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"), "Mensaje 24", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd25"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"), "Mensaje 25", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd26"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc07"), "Mensaje 26", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd27"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc08"), "Mensaje 27", new Guid("33333333-3333-3333-3333-333333333333"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd28"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc09"), "Mensaje 28", new Guid("44444444-4444-4444-4444-444444444444"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd29"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc10"), "Mensaje 29", new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd30"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccc11"), "Mensaje 30", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb01"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb02"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb03"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb04"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb05"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb06"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb07"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb08"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb09"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb10"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb11"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb12"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb13"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb14"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb15"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb16"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb17"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb18"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb19"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb20"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb21"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb22"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb23"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb24"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbb25"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd01"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd02"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd16"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd17"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd18"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd19"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd20"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd21"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd22"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd23"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd24"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd25"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd26"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd27"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd28"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd29"));

            migrationBuilder.DeleteData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd30"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee01"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee02"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee03"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee04"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee05"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee06"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee07"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee08"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee09"));

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee10"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc01"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc07"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc08"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc09"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc10"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc11"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc12"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc13"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc14"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc15"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc16"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc17"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc18"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc19"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc20"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa01"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa02"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa03"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa04"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa05"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa06"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa07"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa08"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa09"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa10"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa11"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa12"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa13"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa14"));

            migrationBuilder.DeleteData(
                table: "Listings",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaa15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));
        }
    }
}

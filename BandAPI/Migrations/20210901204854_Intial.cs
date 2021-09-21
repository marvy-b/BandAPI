using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BandAPI.Migrations
{
    public partial class Intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Founded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MainGenre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[,]
                {
                    { new Guid("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4"), new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Metallic" },
                    { new Guid("4323e0b5-58b4-4e9e-9eff-f35aad529f25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1970), "Afrobeat", "Fela Kuti & Africa 70" },
                    { new Guid("f17ebd4a-dd77-46fd-95dc-202727da4e64"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2018), "Highlife", "The Cavemen" },
                    { new Guid("9f7522ec-4eec-45e1-8e2e-8887c69933d1"), new DateTime(1981, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop", "A-ha" },
                    { new Guid("a8be796f-f2fc-4e1f-a36b-08f60cddc22f"), new DateTime(1991, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alternative", "Oasis" },
                    { new Guid("873a1ffd-d60f-46bb-ae64-b5a642b0eae2"), new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Guns N Roses" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("91888f1b-acfd-4749-aaf0-21142fbf4816"), new Guid("379dfaa6-a6ec-47ca-ac35-ecd49d9dc3c4"), "One of the best heavy metal albums ever", "Master of Puppets" },
                    { new Guid("ec8c3f22-1d68-4e98-965a-bd44b18988e5"), new Guid("4323e0b5-58b4-4e9e-9eff-f35aad529f25"), "Amazing Afrobeat album with raw sound", "Zombie" },
                    { new Guid("65fd490c-5dbd-45c9-8a44-5a8efa873024"), new Guid("f17ebd4a-dd77-46fd-95dc-202727da4e64"), "Very groovy album with badass beat", "The Roots" },
                    { new Guid("8ceda5ae-3713-4343-9db5-a4a8a52699b5"), new Guid("9f7522ec-4eec-45e1-8e2e-8887c69933d1"), "Awesome Debut album by A-Ha", "Hunting Hight and Low" },
                    { new Guid("498ee919-d3e8-4ad5-929a-fa4b7c14e18d"), new Guid("a8be796f-f2fc-4e1f-a36b-08f60cddc22f"), "Arguably one of the best albums by Oasis", "Be Here Now" },
                    { new Guid("984c767b-93f8-49c9-a0c9-33089ec7d12a"), new Guid("873a1ffd-d60f-46bb-ae64-b5a642b0eae2"), "Great Sound", "Waterloo" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_BandId",
                table: "Albums",
                column: "BandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}

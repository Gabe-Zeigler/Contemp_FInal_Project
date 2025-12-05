using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contemp_FInal_Project.Migrations
{
    /// <inheritdoc />
    public partial class sportmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    SportId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayersPerTeam = table.Column<int>(type: "int", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOlympicSport = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.SportId);
                });

            migrationBuilder.CreateTable(
                name: "VideoGamesTables",
                columns: table => new
                {
                    GameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ratings = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGamesTables", x => x.GameID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "VideoGamesTables");
        }
    }
}

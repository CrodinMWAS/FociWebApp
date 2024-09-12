using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FociWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_329 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Round = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeTeamHalfTime = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayTeamHalfTime = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeTeamGoals = table.Column<int>(type: "INTEGER", nullable: false),
                    AwayTeamGoals = table.Column<int>(type: "INTEGER", nullable: false),
                    HomeTeam = table.Column<string>(type: "TEXT", nullable: false),
                    AwayTeam = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JustGideon.DSA5CharacterManager.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "WeatherForecasts",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    WirkungIdentifier = table.Column<string>(type: "longtext", nullable: false),
                    WirkungDescription = table.Column<string>(type: "longtext", nullable: true),
                    Zauberdauer = table.Column<string>(type: "longtext", nullable: false),
                    AsPKosten = table.Column<string>(type: "longtext", nullable: false),
                    Reichweite = table.Column<string>(type: "longtext", nullable: false),
                    Wirkungsdauer = table.Column<string>(type: "longtext", nullable: false),
                    Zielkategorie = table.Column<string>(type: "longtext", nullable: false),
                    Feature = table.Column<int>(type: "int", nullable: false),
                    Verbreitung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "WeatherForecasts",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");
        }
    }
}

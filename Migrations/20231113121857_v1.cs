using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GoldNotification.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Golds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Standard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Golds", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Golds",
                columns: new[] { "Id", "Price", "Standard" },
                values: new object[,]
                {
                    { 1, 2200m, "24" },
                    { 2, 1500m, "21" },
                    { 3, 990m, "18" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Golds");
        }
    }
}

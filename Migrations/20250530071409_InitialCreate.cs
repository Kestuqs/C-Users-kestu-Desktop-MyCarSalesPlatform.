using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCarSalesPlatform.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aprasymas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kaina = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Marke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Metai = table.Column<int>(type: "int", nullable: false),
                    Rida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spalva = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variklis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KuroTipas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PavarųDėžė = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nuotraukos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sukurtas = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listings");
        }
    }
}

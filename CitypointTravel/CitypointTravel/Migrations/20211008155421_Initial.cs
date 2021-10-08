using Microsoft.EntityFrameworkCore.Migrations;

namespace CitypointTravel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weather = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costOfFood = table.Column<double>(type: "float", nullable: false),
                    taxiCost = table.Column<double>(type: "float", nullable: false),
                    apartmentCost = table.Column<double>(type: "float", nullable: false),
                    qualityOfLife = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    costOfLiving = table.Column<double>(type: "float", nullable: false),
                    distance = table.Column<double>(type: "float", nullable: false),
                    cityRating = table.Column<double>(type: "float", nullable: false),
                    pollutionIndex = table.Column<double>(type: "float", nullable: false),
                    isFavourite = table.Column<bool>(type: "bit", nullable: false),
                    Citiesid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cities_Cities_Citiesid",
                        column: x => x.Citiesid,
                        principalTable: "Cities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Citiesid",
                table: "Cities",
                column: "Citiesid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace CitypointTravel.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitiesInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weather = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostOfFood = table.Column<double>(type: "float", nullable: false),
                    TaxiCost = table.Column<double>(type: "float", nullable: false),
                    ApartmentCost = table.Column<double>(type: "float", nullable: false),
                    QualityOfLife = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostOfLiving = table.Column<double>(type: "float", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    CityRating = table.Column<double>(type: "float", nullable: false),
                    PollutionIndex = table.Column<double>(type: "float", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitiesInfo_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesInfo_CityId",
                table: "CitiesInfo",
                column: "CityId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitiesInfo");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}

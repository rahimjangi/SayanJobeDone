using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SayanJobeDone.Shared.Migrations
{
    public partial class listOfCitiesNotNeedInCountry1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Cities",
                newName: "CityName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "Name");
        }
    }
}

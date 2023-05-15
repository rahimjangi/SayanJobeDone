using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SayanJobeDone.Shared.Migrations
{
    public partial class changeOfIds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceProviders_ServiceProviderId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ServiceProviderId",
                table: "Services",
                newName: "ServiceProvidersId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ServiceProviderId",
                table: "Services",
                newName: "IX_Services_ServiceProvidersId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "RateTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MobilePhones",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "LocationDatas",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceProviders_ServiceProvidersId",
                table: "Services",
                column: "ServiceProvidersId",
                principalTable: "ServiceProviders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_ServiceProviders_ServiceProvidersId",
                table: "Services");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ServiceProvidersId",
                table: "Services",
                newName: "ServiceProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Services_ServiceProvidersId",
                table: "Services",
                newName: "IX_Services_ServiceProviderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RateTypes",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MobilePhones",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LocationDatas",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_ServiceProviders_ServiceProviderId",
                table: "Services",
                column: "ServiceProviderId",
                principalTable: "ServiceProviders",
                principalColumn: "Id");
        }
    }
}

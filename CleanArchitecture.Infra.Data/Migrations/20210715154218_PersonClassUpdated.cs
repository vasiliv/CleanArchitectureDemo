using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.Infra.Data.Migrations
{
    public partial class PersonClassUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactFirstName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactLastName",
                table: "Persons",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactFirstName",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ContactLastName",
                table: "Persons");
        }
    }
}

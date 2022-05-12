using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class add_inspectiontype_inspection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Returned",
                table: "Rents",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InspectionType",
                table: "Inspections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Returned",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "InspectionType",
                table: "Inspections");
        }
    }
}

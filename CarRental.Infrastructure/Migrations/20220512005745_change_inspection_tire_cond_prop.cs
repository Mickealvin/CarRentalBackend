using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRental.Infrastructure.Migrations
{
    public partial class change_inspection_tire_cond_prop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TireCondition",
                table: "Inspections",
                newName: "ThirdTireCondition");

            migrationBuilder.AddColumn<bool>(
                name: "FirstTireCondition",
                table: "Inspections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FourthTireCondition",
                table: "Inspections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondTireCondition",
                table: "Inspections",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstTireCondition",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "FourthTireCondition",
                table: "Inspections");

            migrationBuilder.DropColumn(
                name: "SecondTireCondition",
                table: "Inspections");

            migrationBuilder.RenameColumn(
                name: "ThirdTireCondition",
                table: "Inspections",
                newName: "TireCondition");
        }
    }
}

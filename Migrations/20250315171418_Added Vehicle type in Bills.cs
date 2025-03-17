using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransportModule1.Migrations
{
    /// <inheritdoc />
    public partial class AddedVehicletypeinBills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Bills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Bills");
        }
    }
}

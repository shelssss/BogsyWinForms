using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BogsyVideoStore.Migrations
{
    /// <inheritdoc />
    public partial class AddedRentCost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentCost",
                table: "CustomerRented",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentCost",
                table: "CustomerRented");
        }
    }
}

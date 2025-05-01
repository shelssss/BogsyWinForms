using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BogsyVideoStore.Migrations
{
    /// <inheritdoc />
    public partial class AddMaxRentDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxRentDays",
                table: "Video",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxRentDays",
                table: "Video");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BogsyVideoStore.Migrations
{
    /// <inheritdoc />
    public partial class AddedVidId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoId",
                table: "CustomerRented",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "CustomerRented");
        }
    }
}

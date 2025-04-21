using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BogsyVideoStore.Migrations
{
    /// <inheritdoc />
    public partial class AddedRentedVideo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RentedVideos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoRented = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ReturnedDate = table.Column<DateOnly>(type: "date", nullable: true),
                    RentCost = table.Column<int>(type: "int", nullable: false),
                    LateReturnFee = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentedVideos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RentedVideos");
        }
    }
}

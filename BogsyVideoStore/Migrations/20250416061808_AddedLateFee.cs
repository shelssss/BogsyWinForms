using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BogsyVideoStore.Migrations
{
    /// <inheritdoc />
    public partial class AddedLateFee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LateReturnFee",
                table: "CustomerRented",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateOnly>(
                name: "ReturnedDate",
                table: "CustomerRented",
                type: "date",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LateReturnFee",
                table: "CustomerRented");

            migrationBuilder.DropColumn(
                name: "ReturnedDate",
                table: "CustomerRented");
        }
    }
}

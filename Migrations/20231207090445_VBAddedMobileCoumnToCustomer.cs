﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationCodeDemo.Migrations
{
    /// <inheritdoc />
    public partial class VBAddedMobileCoumnToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerMobile",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerMobile",
                table: "Customers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationCodeDemo.Migrations
{
    /// <inheritdoc />
    public partial class VBAddedAgainMobileToCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerMobile",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
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

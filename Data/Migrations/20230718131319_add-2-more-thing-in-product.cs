using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class add2morethinginproduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Branch",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Product");
        }
    }
}

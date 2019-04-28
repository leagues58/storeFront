using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreFront.Migrations
{
    public partial class ProductModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Products");
        }
    }
}

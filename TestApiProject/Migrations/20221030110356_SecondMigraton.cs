using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApiProject.Migrations
{
    public partial class SecondMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    slNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.slNo);
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "slNo", "Price", "ProductDetail", "ProductName", "ProductType" },
                values: new object[] { 101, 2000, "Operating System", "Windows OS", "Hardware" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApp.Server.Migrations
{
    public partial class ProductVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductTypeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Hard Copy" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Digital Download" });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 1, 1, 18.99m, 11.99m },
                    { 1, 2, 0m, 10.50m },
                    { 2, 1, 0m, 49.99m },
                    { 2, 2, 0m, 39.99m },
                    { 3, 1, 0m, 13.50m },
                    { 3, 2, 0m, 12.50m },
                    { 4, 1, 15.99m, 12.99m },
                    { 4, 2, 12.00m, 6.50m },
                    { 5, 1, 0m, 75.00m },
                    { 5, 2, 0m, 60.00m },
                    { 6, 1, 0m, 42.00m },
                    { 6, 2, 24.99m, 18.00m },
                    { 7, 1, 35.00m, 27.50m },
                    { 7, 2, 0m, 24.99m },
                    { 8, 1, 0m, 14.00m },
                    { 8, 2, 0m, 16.50m },
                    { 9, 1, 0m, 7.99m },
                    { 9, 2, 0m, 8.99m },
                    { 10, 1, 55.00m, 30.00m },
                    { 10, 2, 0m, 35.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Price",
                value: 19.79m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Price",
                value: 19.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Price",
                value: 39.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 35.98m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Price",
                value: 19.20m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Price",
                value: 69.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "Price",
                value: 49.99m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "Price",
                value: 14.87m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "Price",
                value: 28.24m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "Price",
                value: 17.69m);
        }
    }
}

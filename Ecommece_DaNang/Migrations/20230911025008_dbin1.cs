using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbin1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SoldPrice",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreateOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    PriceProduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Orderdat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tofeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 37m, 8000000m, 5000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 30m, 9000000m, 6000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 30m, 1000000m, 7000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Discount", "SoldPrice" },
                values: new object[] { 30m, 8400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 14000000m, 12600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 25m, 18000000m, 13500000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 20m, 20000000m, 16000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 20000000m, 18000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 18000000m, 16200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 20000000m, 18000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 6000000m, 5400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 20m, 9000000m, 7200000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 14000000m, 12600000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 22000000m, 19800000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 16000000m, 14400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 10m, 26000000m, 23400000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 20m, 70000000m, 56000000m });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                columns: new[] { "Discount", "Price", "SoldPrice" },
                values: new object[] { 15m, 20000000m, 17000000m });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SoldPrice",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Price",
                value: 5000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Price",
                value: 6000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 6500000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Price",
                value: 12500000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "Price",
                value: 15000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "Price",
                value: 15500000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "Price",
                value: 19000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 9,
                column: "Price",
                value: 16000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 10,
                column: "Price",
                value: 16000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 11,
                column: "Price",
                value: 5000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 12,
                column: "Price",
                value: 6790000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 13,
                column: "Price",
                value: 12490000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 14,
                column: "Price",
                value: 19490000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 15,
                column: "Price",
                value: 14090000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 16,
                column: "Price",
                value: 23900000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 17,
                column: "Price",
                value: 51000000m);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 18,
                column: "Price",
                value: 17490000m);
        }
    }
}

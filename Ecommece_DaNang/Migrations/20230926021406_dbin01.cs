using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbin01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "Card",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Card_ImageId",
                table: "Card",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Card_ProductOptionID",
                table: "Card",
                column: "ProductOptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_ImageProduct_ImageId",
                table: "Card",
                column: "ImageId",
                principalTable: "ImageProduct",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_ProductOption_ProductOptionID",
                table: "Card",
                column: "ProductOptionID",
                principalTable: "ProductOption",
                principalColumn: "productOptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_ImageProduct_ImageId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_ProductOption_ProductOptionID",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_ImageId",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_ProductOptionID",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Card");
        }
    }
}

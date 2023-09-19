using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbinit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CateProduct",
                columns: new[] { "CateID", "CateName" },
                values: new object[] { "Iphone", "Iphone 8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CateProduct",
                keyColumn: "CateID",
                keyValue: "Iphone");
        }
    }
}

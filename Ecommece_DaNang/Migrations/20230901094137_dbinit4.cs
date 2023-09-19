using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommece_DaNang.Migrations
{
    /// <inheritdoc />
    public partial class dbinit4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[] { "US", "User" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleID",
                keyValue: "US");
        }
    }
}

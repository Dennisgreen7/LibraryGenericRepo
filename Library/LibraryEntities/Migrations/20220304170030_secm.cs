using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryEntities.Migrations
{
    public partial class secm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "authorId", "authorCountry", "authorName" },
                values: new object[] { 22, "Israel", "Mark" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "authorId",
                keyValue: 22);
        }
    }
}

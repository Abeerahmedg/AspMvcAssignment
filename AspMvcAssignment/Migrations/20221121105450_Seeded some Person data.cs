using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class SeededsomePersondata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "NumberOfBooks" },
                values: new object[,]
                {
                    { "1a00b3c0-b630-4a13-acb9-41d45ec943df", "Devon", "Agatha Christie", 85 },
                    { "45d7888d-621b-4c0d-ba00-a7bf2593f805", "Tanta", "Ahmed Tawfik", 200 },
                    { "8d32397a-9c9e-4bf5-a4df-8f5234d46e70", "New Hampshire", "Dan Brown", 7 },
                    { "93e2a945-a082-48e8-9d2d-996e03da8962", "Tokyo", "Yasuo Uchida", 130 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "1a00b3c0-b630-4a13-acb9-41d45ec943df");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "45d7888d-621b-4c0d-ba00-a7bf2593f805");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "8d32397a-9c9e-4bf5-a4df-8f5234d46e70");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "93e2a945-a082-48e8-9d2d-996e03da8962");
        }
    }
}

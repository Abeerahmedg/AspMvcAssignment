using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "NumberOfBooks" },
                values: new object[,]
                {
                    { "25f18183-9676-4838-bd58-39faf3d1fa6e", "Tokyo", "Yasuo Uchida", 130 },
                    { "84262a31-5655-42c9-a830-bbb1cee079e7", "New Hampshire", "Dan Brown", 7 },
                    { "ac10e7e0-2ec0-4df1-8285-50eabf98b991", "Tanta", "Ahmed Tawfik", 200 },
                    { "bdb0f3f0-859a-4b6d-9e72-6e837e829096", "Devon", "Agatha Christie", 85 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "25f18183-9676-4838-bd58-39faf3d1fa6e");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "84262a31-5655-42c9-a830-bbb1cee079e7");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "ac10e7e0-2ec0-4df1-8285-50eabf98b991");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: "bdb0f3f0-859a-4b6d-9e72-6e837e829096");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class Seededbirthday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7cd76063-052c-4f6a-b958-afeb3a16fd7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa51bc89-b129-4f1a-bb95-8faa6e54c26b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cd84ba9-56ff-4ba9-a021-f57451a6ba87", "fa51bc89-b129-4f1a-bb95-8faa6e54c26b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cd84ba9-56ff-4ba9-a021-f57451a6ba87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa51bc89-b129-4f1a-bb95-8faa6e54c26b");

            migrationBuilder.AddColumn<bool>(
                name: "Admin",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Birthdate",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "06a22d72-5677-4b42-b2a9-25eb508e4424", "548f3778-2129-41f8-ba00-e1327f192ff3", "User", "USER" },
                    { "13087016-9d65-460a-89f9-1d0c0b477e75", "2520b3b1-547e-4f41-976c-02b505408cae", "Moderator", "MODERATOR" },
                    { "f2e4fc06-a6ad-4475-86ba-3d568cff0e8a", "b959c024-20f5-4341-a620-7be3579f9e7e", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "06a22d72-5677-4b42-b2a9-25eb508e4424", 0, false, "1995-03-22", "3a5421fd-78e2-4ca8-bc97-2e3b3b00f772", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBsG9unKK8FyAwO29fSUnTrVTP0tgMDL5MVBwigpqMV1kh4znvpTT/WUsLY4EN4I9Q==", null, false, "9a5ce057-acbb-4240-b681-2e0dfd3e197f", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f2e4fc06-a6ad-4475-86ba-3d568cff0e8a", "06a22d72-5677-4b42-b2a9-25eb508e4424" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06a22d72-5677-4b42-b2a9-25eb508e4424");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13087016-9d65-460a-89f9-1d0c0b477e75");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2e4fc06-a6ad-4475-86ba-3d568cff0e8a", "06a22d72-5677-4b42-b2a9-25eb508e4424" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2e4fc06-a6ad-4475-86ba-3d568cff0e8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06a22d72-5677-4b42-b2a9-25eb508e4424");

            migrationBuilder.DropColumn(
                name: "Admin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Birthdate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5cd84ba9-56ff-4ba9-a021-f57451a6ba87", "bf3637df-d7c1-4874-a914-de43876d35d5", "Admin", "ADMIN" },
                    { "7cd76063-052c-4f6a-b958-afeb3a16fd7d", "8d69d24f-a074-49ec-a5dc-3f5d585bb527", "Moderator", "MODERATOR" },
                    { "fa51bc89-b129-4f1a-bb95-8faa6e54c26b", "a9cad551-6651-495b-95a8-362b4718c579", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fa51bc89-b129-4f1a-bb95-8faa6e54c26b", 0, "833b3c60-cd47-465c-b980-4af733d93983", "admin@admin.com", false, "Abeer", "Ahmed", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIlq6qM5JWkSiIRAwGq+7Tgahth9kZByg6C6cY65RNY8nwig6ozagaR3hYHsfD6bww==", null, false, "af27d514-84bc-4af8-a3b2-6cc0cedd77a8", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5cd84ba9-56ff-4ba9-a021-f57451a6ba87", "fa51bc89-b129-4f1a-bb95-8faa6e54c26b" });
        }
    }
}

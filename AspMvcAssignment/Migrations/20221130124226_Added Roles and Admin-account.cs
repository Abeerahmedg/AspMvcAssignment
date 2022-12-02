using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class AddedRolesandAdminaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

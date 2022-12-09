using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class ppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae775664-33af-44cc-8ad0-94fd4a37c733", "61581ea1-435f-47f0-985d-4949dff39c82", "Moderator", "MODERATOR" },
                    { "cbd06b0e-a760-43d9-af52-2c30a4e96bb2", "4579c501-aeb4-4eca-80d2-e04c6d0a5c3d", "Admin", "ADMIN" },
                    { "d2a97bd1-6499-4e94-975b-468565e04fd0", "c0635b1e-cfb4-4d69-b4c6-6870196a4dcd", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2a97bd1-6499-4e94-975b-468565e04fd0", 0, false, "1995-03-22", "d5de51e9-b5c9-41e4-ab0f-81927144a632", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELYBAYfVTDpHsM01GkwYWOVMG1CDc/X5jCCmyWUFrXSi90smve8/OKeJO650lHk5mg==", null, false, "43f5e3ff-b25a-4cb2-921a-68f2c2d1bcf7", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cbd06b0e-a760-43d9-af52-2c30a4e96bb2", "d2a97bd1-6499-4e94-975b-468565e04fd0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae775664-33af-44cc-8ad0-94fd4a37c733");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2a97bd1-6499-4e94-975b-468565e04fd0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cbd06b0e-a760-43d9-af52-2c30a4e96bb2", "d2a97bd1-6499-4e94-975b-468565e04fd0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbd06b0e-a760-43d9-af52-2c30a4e96bb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2a97bd1-6499-4e94-975b-468565e04fd0");

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
    }
}

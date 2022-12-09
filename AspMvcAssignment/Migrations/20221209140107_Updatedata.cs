using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMvcAssignment.Migrations
{
    public partial class Updatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "25b3a9a9-3706-4b05-acd8-3bdf4ed53f47", "8f2b5dc0-0d3c-4bb8-9464-264358548aed", "Admin", "ADMIN" },
                    { "454b1cd2-455d-472c-8556-0b5d2cb038b0", "fb99f93f-02c8-4a94-bfe7-3788e63aa906", "Moderator", "MODERATOR" },
                    { "bb810b91-d18a-450f-9bde-2ca75589f0dc", "38c172df-c434-4104-9e5f-9d4890909a11", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Admin", "Birthdate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb810b91-d18a-450f-9bde-2ca75589f0dc", 0, false, "1995-03-22", "ee82d70a-5d64-421a-b69a-3471aaee3d17", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENR2ENjE9apceEDnYqdoXZ5cK3R1LEyLF9F2R40OdiKf6jlDEieZ3JaKur1237ZiLg==", null, false, "f128b686-c9bd-4208-a95f-aa837fd46b0e", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "NumberOfBooks" },
                values: new object[] { 5, 7, "Ahmed fdssa", 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "25b3a9a9-3706-4b05-acd8-3bdf4ed53f47", "bb810b91-d18a-450f-9bde-2ca75589f0dc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "454b1cd2-455d-472c-8556-0b5d2cb038b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb810b91-d18a-450f-9bde-2ca75589f0dc");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25b3a9a9-3706-4b05-acd8-3bdf4ed53f47", "bb810b91-d18a-450f-9bde-2ca75589f0dc" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25b3a9a9-3706-4b05-acd8-3bdf4ed53f47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb810b91-d18a-450f-9bde-2ca75589f0dc");

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class FixBugValidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50eecd0e-cef3-46b8-85e8-a70fba8aaab7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4cc717f-30da-4809-aa77-f4fdd71a6ea5");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "75308cff-7fe7-4955-9382-8b1608a71be2", "7f9f3eee-aa35-48e4-8b49-f0dd83bfb3fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe40dc5e-d957-4c4f-8f9d-6eaac51b92c4", "e056df3b-9d9d-47cf-8ec7-0b336fef6d62" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75308cff-7fe7-4955-9382-8b1608a71be2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe40dc5e-d957-4c4f-8f9d-6eaac51b92c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f9f3eee-aa35-48e4-8b49-f0dd83bfb3fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e056df3b-9d9d-47cf-8ec7-0b336fef6d62");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45376bb7-bd5b-4b5c-9a44-a40a2b4a6887", "89f9c5fa-5644-4c01-954a-a278cd01968a", "Admin", "ADMIN" },
                    { "d6cd0dc4-2fb8-437f-a7fe-b35c81600817", "c4d42cd0-d9b6-46a2-91c3-87439783dc80", "Staff", "STAFF" },
                    { "e1503004-408d-4394-8086-f4658718e68d", "dd5a66c3-428d-4bfc-8c5a-055b4b26b088", "Trainer", "TRAINER" },
                    { "15b82ac8-650a-40d3-a585-27057fb78449", "71837aa2-3651-4321-96cc-3824edd8cfd2", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fd8c7de0-17aa-4e12-a14e-b96a30a84280", 0, null, 0, "4d29004a-add5-438b-8f76-d8163f4347de", "admin@gmail.com", true, "Le Trung Kien", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEI/II67lcfMZMSRqS71vXDNSpM3Zd//T2Yycc6fwTqU1felqBs0tC4S8G9zAq7Zocg==", null, true, "c994c603-8c8e-474e-ad75-b1e6b0275e46", false, "admin@gmail.com" },
                    { "bce98df9-7ad0-4b92-8ff4-2dd83e09035b", 0, null, 0, "64e3d21a-846e-456d-8359-78c275a8e089", "staff@gmail.com", true, "Le Tran Thai Tuan", false, null, null, null, "AQAAAAEAACcQAAAAEAXWzl6ST3DTDD2TYC2kA9cauCkahCPKG4BLdz1L/Ili7luylZX1BFIH4pyNzXsaAQ==", null, true, "9db1d1d3-f51f-41a6-9a89-7166dcd8ada0", false, "staff@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "45376bb7-bd5b-4b5c-9a44-a40a2b4a6887", "fd8c7de0-17aa-4e12-a14e-b96a30a84280" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d6cd0dc4-2fb8-437f-a7fe-b35c81600817", "bce98df9-7ad0-4b92-8ff4-2dd83e09035b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b82ac8-650a-40d3-a585-27057fb78449");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1503004-408d-4394-8086-f4658718e68d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d6cd0dc4-2fb8-437f-a7fe-b35c81600817", "bce98df9-7ad0-4b92-8ff4-2dd83e09035b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "45376bb7-bd5b-4b5c-9a44-a40a2b4a6887", "fd8c7de0-17aa-4e12-a14e-b96a30a84280" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45376bb7-bd5b-4b5c-9a44-a40a2b4a6887");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6cd0dc4-2fb8-437f-a7fe-b35c81600817");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bce98df9-7ad0-4b92-8ff4-2dd83e09035b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd8c7de0-17aa-4e12-a14e-b96a30a84280");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fe40dc5e-d957-4c4f-8f9d-6eaac51b92c4", "c8360899-dc4a-4192-a191-961ea3933063", "Admin", "ADMIN" },
                    { "75308cff-7fe7-4955-9382-8b1608a71be2", "5cad7d42-34b9-410c-a01a-a20acb0a67f9", "Staff", "STAFF" },
                    { "b4cc717f-30da-4809-aa77-f4fdd71a6ea5", "839191ac-be4a-4ec8-ad81-911400173091", "Trainer", "TRAINER" },
                    { "50eecd0e-cef3-46b8-85e8-a70fba8aaab7", "3b47a533-9b41-4c12-993a-ebc60d483f95", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e056df3b-9d9d-47cf-8ec7-0b336fef6d62", 0, null, 0, "b5e94219-448f-46da-b185-2c333840fe6c", "admin@gmail.com", true, "Le Trung Kien", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEI6CQXkhgHQz1fMYX7gNhoGhHQsOw7uUBOarFfvhaZaMSHgiCZqFmF/nkYmZqwL5jg==", null, true, "812ae9e4-a21b-415d-8af7-ca42690b6b66", false, "admin@gmail.com" },
                    { "7f9f3eee-aa35-48e4-8b49-f0dd83bfb3fe", 0, null, 0, "ad60b669-2394-4f13-bc7d-77628d5fa659", "staff@gmail.com", true, "Le Tran Thai Tuan", false, null, null, null, "AQAAAAEAACcQAAAAEKq6BGCf0aWboZqxpt4IW9iHK53BD6kdiGMOeveKGfvmPEELKfpaS/4izrdI3Lq/og==", null, true, "b038ec0f-7195-4f82-a3c1-a4705ed1f6a6", false, "staff@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fe40dc5e-d957-4c4f-8f9d-6eaac51b92c4", "e056df3b-9d9d-47cf-8ec7-0b336fef6d62" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "75308cff-7fe7-4955-9382-8b1608a71be2", "7f9f3eee-aa35-48e4-8b49-f0dd83bfb3fe" });
        }
    }
}

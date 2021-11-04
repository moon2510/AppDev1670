using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class fixwritewrong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b683a767-4c15-4a76-a652-82f8d98bd160");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dbaeebb9-7008-4112-9267-96e232eebe09");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a67150b-ff3b-4b03-9a8b-c8e9acca9edf", "6fbf7958-e5d6-44ce-b3de-3ffcd00fd7bf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa066d24-8601-4b73-bf81-6d387ad55afc", "e2d2cf72-528a-44cb-8b6b-da4a3403fdaa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a67150b-ff3b-4b03-9a8b-c8e9acca9edf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa066d24-8601-4b73-bf81-6d387ad55afc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fbf7958-e5d6-44ce-b3de-3ffcd00fd7bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2d2cf72-528a-44cb-8b6b-da4a3403fdaa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f32b5a4b-884c-4e44-b4b7-4b341d124bd2", "62dc0e63-e834-4edd-a085-a9fb18a80ad5", "Admin", "ADMIN" },
                    { "386c0cb9-a4f3-468e-96c2-09b57b27292f", "2c3dfc00-0d81-4ef6-bfd8-c15ce33ded16", "Staff", "STAFF" },
                    { "1bb2b0ff-c219-45d1-a078-559385a6d85f", "80b15ae7-1178-46c0-8a57-32f25274ae5d", "Trainer", "TRAINER" },
                    { "2454d6bb-509b-45e4-b412-9250427d3f37", "ffa4b664-8fc5-4899-b494-c85321470681", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ed3867f-615b-4eb0-be1b-2f12eeae9cde", 0, null, 0, "758de8c6-d6a2-4e81-91c4-542cf0009bf2", "admin@gmail.com", true, "Le Trung Kien", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEBBjIPu72rBXRx7dAeNwz+ZuwWqVIg68/R+LYt/+MO1s5w74qXiwwAdC8ts9dLPGjA==", null, true, "453f0d5a-662f-4b6f-8a08-03336040ef2f", false, "admin@gmail.com" },
                    { "c67283c7-b1d6-4480-99be-4a474fe26167", 0, null, 0, "aad2c802-0f45-4d36-b584-35c683fdd0ba", "staff@gmail.com", true, "Le Tran Thai Tuan", false, null, null, null, "AQAAAAEAACcQAAAAECMcE7EO0mJbxP/gAK5K6uU8CzDqfIW2iR1iZO7Jbanx/JLfTCaCIw/OAwI7r4GsLw==", null, true, "0e09f759-9be2-4605-be88-f54e1a888147", false, "staff@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f32b5a4b-884c-4e44-b4b7-4b341d124bd2", "5ed3867f-615b-4eb0-be1b-2f12eeae9cde" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "386c0cb9-a4f3-468e-96c2-09b57b27292f", "c67283c7-b1d6-4480-99be-4a474fe26167" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb2b0ff-c219-45d1-a078-559385a6d85f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2454d6bb-509b-45e4-b412-9250427d3f37");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f32b5a4b-884c-4e44-b4b7-4b341d124bd2", "5ed3867f-615b-4eb0-be1b-2f12eeae9cde" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "386c0cb9-a4f3-468e-96c2-09b57b27292f", "c67283c7-b1d6-4480-99be-4a474fe26167" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "386c0cb9-a4f3-468e-96c2-09b57b27292f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f32b5a4b-884c-4e44-b4b7-4b341d124bd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ed3867f-615b-4eb0-be1b-2f12eeae9cde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c67283c7-b1d6-4480-99be-4a474fe26167");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fa066d24-8601-4b73-bf81-6d387ad55afc", "62a38795-fff2-4f47-9f5e-9c773160e3ec", "Admin", "ADMIN" },
                    { "1a67150b-ff3b-4b03-9a8b-c8e9acca9edf", "c30e3587-fb73-4dd4-a298-f86983f1fb5e", "Staff", "STAFF" },
                    { "dbaeebb9-7008-4112-9267-96e232eebe09", "675a2cf1-ebb4-4a06-8c5d-bcc7e8b85683", "Trainer", "TRAINER" },
                    { "b683a767-4c15-4a76-a652-82f8d98bd160", "75753d2c-885d-46d8-871f-9da79255b520", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e2d2cf72-528a-44cb-8b6b-da4a3403fdaa", 0, null, 0, "982a10f2-ab14-47e2-8861-1f9a226c0ceb", "admin@gmail.com", true, "Le Trung Kien", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEPQaaa6QArtBDPlqyVJKF8na0ASSbm/Y13eDFEYrzhJCJNMhf3pnk9LTk7sMph9e3A==", null, true, "f3307ff1-1971-4fa2-a724-35f9c9427917", false, "admin@gmail.com" },
                    { "6fbf7958-e5d6-44ce-b3de-3ffcd00fd7bf", 0, null, 0, "c90ce03c-2afd-47ed-8b43-2a23bdbbbf06", "staff@gmail.com", true, "Le Tran Thai Tuan", false, null, null, null, "AQAAAAEAACcQAAAAELden/yZWORJ3wgerqUcKBgrjbgo0yG4ryMN1PuqSUpbZWXzWPe8/wdP7Wa+q8lgKA==", null, true, "c8c07c0b-d80c-4256-805a-5113d1325551", false, "staff@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa066d24-8601-4b73-bf81-6d387ad55afc", "e2d2cf72-528a-44cb-8b6b-da4a3403fdaa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a67150b-ff3b-4b03-9a8b-c8e9acca9edf", "6fbf7958-e5d6-44ce-b3de-3ffcd00fd7bf" });
        }
    }
}

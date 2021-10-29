using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class dbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "TrainerProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Education",
                table: "TraineeProfiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "TrainerProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Education",
                table: "TraineeProfiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}

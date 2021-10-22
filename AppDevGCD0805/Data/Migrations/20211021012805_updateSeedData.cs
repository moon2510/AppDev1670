using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class updateSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18b891b5-e12a-430e-bad0-47f62c820cbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f37717ed-3abe-4e88-9566-814d0bccd28f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f422ddf5-4b35-4280-a9c1-8455c34c9ca3", "99a0d65f-e071-4e3f-9dfb-b51651c6f148" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2741778b-ebe6-4eda-a410-a29e79117a7e", "e48d61de-1aad-409a-b816-0fbcafb0b828" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2741778b-ebe6-4eda-a410-a29e79117a7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f422ddf5-4b35-4280-a9c1-8455c34c9ca3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99a0d65f-e071-4e3f-9dfb-b51651c6f148");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e48d61de-1aad-409a-b816-0fbcafb0b828");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2741778b-ebe6-4eda-a410-a29e79117a7e", "aa518e65-833d-406b-8c97-a299c61baa61", "Admin", "ADMIN" },
                    { "f422ddf5-4b35-4280-a9c1-8455c34c9ca3", "38b5f4c8-e23b-4bc0-8f14-cb32434ea2a8", "Staff", "STAFF" },
                    { "18b891b5-e12a-430e-bad0-47f62c820cbc", "c6e1a026-5f53-4985-9677-8859da50a45d", "Trainer", "TRAINER" },
                    { "f37717ed-3abe-4e88-9566-814d0bccd28f", "6cf3e930-8572-47e4-8684-69ce0a141424", "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e48d61de-1aad-409a-b816-0fbcafb0b828", 0, null, 0, "ce43bb37-babd-42d7-9708-9c4344eff756", "admin@gmail.com", true, "Le Trung Kien", false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEFU+BcbXj4BJL4gv9Z3yziZH4ba3fzF1nSTwL7XaLjgICzLMTyWaGmsItllyJLUsbg==", null, true, "9e24c652-8a43-4101-862d-98869a25f507", false, "admin" },
                    { "99a0d65f-e071-4e3f-9dfb-b51651c6f148", 0, null, 0, "75a4202c-3e6a-485d-ad7a-149fdafa18ab", "staff@gmail.com", true, "Le Tran Thai Tuan", false, null, null, null, "AQAAAAEAACcQAAAAEOI+HnfgNV8H/wKzCdwTHjCPpwLDnaXfhHMsjofYUMdMdiWyWPXV6n2IqbJpfTAL7w==", null, true, "f471c990-0edc-4d10-844e-091abc0b36ba", false, "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2741778b-ebe6-4eda-a410-a29e79117a7e", "e48d61de-1aad-409a-b816-0fbcafb0b828" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f422ddf5-4b35-4280-a9c1-8455c34c9ca3", "99a0d65f-e071-4e3f-9dfb-b51651c6f148" });
        }
    }
}

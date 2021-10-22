using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class TraineeProfile : Migration
    {
        public object User { get; internal set; }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TraineeProfiles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TraineeProfiles", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_TraineeProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TraineeProfiles");
        }
    }
}

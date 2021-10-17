using Microsoft.EntityFrameworkCore.Migrations;

namespace AppDevGCD0805.Data.Migrations
{
    public partial class AssignTrainerCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssignTrainerCourses",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignTrainerCourses", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_AssignTrainerCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AssignTrainerCourses_TrainerProfiles_UserId",
                        column: x => x.UserId,
                        principalTable: "TrainerProfiles",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignTrainerCourses_CourseId",
                table: "AssignTrainerCourses",
                column: "CourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignTrainerCourses");
        }
    }
}

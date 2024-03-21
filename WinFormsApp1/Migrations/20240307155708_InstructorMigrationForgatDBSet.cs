using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningSystem.Migrations
{
    /// <inheritdoc />
    public partial class InstructorMigrationForgatDBSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_DepartmentName",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Instructor_HeadedBy",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_HeadedBy",
                table: "Instructors",
                newName: "IX_Instructors_HeadedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_DepartmentName",
                table: "Instructors",
                newName: "IX_Instructors_DepartmentName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentName",
                table: "Instructors",
                column: "DepartmentName",
                principalTable: "Departments",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Instructors_HeadedBy",
                table: "Instructors",
                column: "HeadedBy",
                principalTable: "Instructors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentName",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Instructors_HeadedBy",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_HeadedBy",
                table: "Instructor",
                newName: "IX_Instructor_HeadedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_DepartmentName",
                table: "Instructor",
                newName: "IX_Instructor_DepartmentName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_DepartmentName",
                table: "Instructor",
                column: "DepartmentName",
                principalTable: "Departments",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Instructor_HeadedBy",
                table: "Instructor",
                column: "HeadedBy",
                principalTable: "Instructor",
                principalColumn: "Id");
        }
    }
}

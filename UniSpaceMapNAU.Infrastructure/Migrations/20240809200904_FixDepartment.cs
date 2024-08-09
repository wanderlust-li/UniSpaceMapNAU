using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniSpaceMapNAU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentsGroups_Departments_DepartamentId",
                table: "StudentsGroups");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "StudentsGroups",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsGroups_DepartamentId",
                table: "StudentsGroups",
                newName: "IX_StudentsGroups_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsGroups_Departments_DepartmentId",
                table: "StudentsGroups",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentsGroups_Departments_DepartmentId",
                table: "StudentsGroups");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "StudentsGroups",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_StudentsGroups_DepartmentId",
                table: "StudentsGroups",
                newName: "IX_StudentsGroups_DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsGroups_Departments_DepartamentId",
                table: "StudentsGroups",
                column: "DepartamentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

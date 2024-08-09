using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniSpaceMapNAU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addStudentGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsGroups_Departments_DepartamentId",
                        column: x => x.DepartamentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StudentsGroups",
                columns: new[] { "Id", "DepartamentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Group A" },
                    { 2, 1, "Group B" },
                    { 3, 1, "Group C" },
                    { 4, 4, "Group E" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsGroups_DepartamentId",
                table: "StudentsGroups",
                column: "DepartamentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsGroups");
        }
    }
}

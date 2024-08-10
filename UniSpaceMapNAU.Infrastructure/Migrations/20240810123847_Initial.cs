using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniSpaceMapNAU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialtyNumber = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsGroups_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Корпус 1" },
                    { 2, "Корпус 2" },
                    { 3, "Корпус 3" },
                    { 4, "Корпус 4" },
                    { 5, "Корпус 5" },
                    { 6, "Корпус 6" },
                    { 7, "Корпус 7" },
                    { 8, "Корпус 8" },
                    { 9, "Корпус 9" },
                    { 10, "Корпус 10" },
                    { 11, "Корпус 11" },
                    { 12, "Корпус 12" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ФКНТ" },
                    { 2, "ФАЕТ" },
                    { 3, "ФЕБА" },
                    { 4, "ФЕБІТ" },
                    { 5, "АКФ" },
                    { 6, "ФЛСК" },
                    { 7, "ФМВ" },
                    { 8, "ФНСА" },
                    { 9, "ФТМЛ" },
                    { 10, "ЮФ" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Лекційна" },
                    { 2, "Практична" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "FacultyId", "Name", "SpecialtyNumber" },
                values: new object[,]
                {
                    { 1, 1, "Прикладна математика", 113 },
                    { 2, 1, "Кібербезпека", 125 },
                    { 3, 1, "Компʼютерні науки", 122 },
                    { 4, 1, "Компʼютерна інженерія", 123 },
                    { 5, 1, "Інформаційні системи та технології", 126 }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "FloorNumber" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 }
                });

            migrationBuilder.InsertData(
                table: "StudentsGroups",
                columns: new[] { "Id", "DepartmentId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Group A" },
                    { 2, 1, "Group B" },
                    { 3, 1, "Group C" },
                    { 4, 4, "Group E" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_FacultyId",
                table: "Departments",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsGroups_DepartmentId",
                table: "StudentsGroups",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "StudentsGroups");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}

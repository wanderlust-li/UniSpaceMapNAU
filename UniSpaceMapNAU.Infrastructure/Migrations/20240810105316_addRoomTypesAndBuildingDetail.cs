using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniSpaceMapNAU.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addRoomTypesAndBuildingDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingDetails", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "BuildingDetails",
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
                table: "RoomTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Лекційна" },
                    { 2, "Практична" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildingDetails");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}

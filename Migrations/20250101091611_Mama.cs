using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THE_REAL_ONE.Migrations
{
    /// <inheritdoc />
    public partial class Mama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HisPProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisPProjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HisTTeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisTTeamMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HisTTasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HisProjectID = table.Column<int>(type: "int", nullable: false),
                    HisTeamMemberID = table.Column<int>(type: "int", nullable: false),
                    HisPProjectsId = table.Column<int>(type: "int", nullable: true),
                    HisTTeamMembersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HisTTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HisTTasks_HisPProjects_HisPProjectsId",
                        column: x => x.HisPProjectsId,
                        principalTable: "HisPProjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HisTTasks_HisTTeamMembers_HisTTeamMembersId",
                        column: x => x.HisTTeamMembersId,
                        principalTable: "HisTTeamMembers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HisTTasks_HisPProjectsId",
                table: "HisTTasks",
                column: "HisPProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_HisTTasks_HisTTeamMembersId",
                table: "HisTTasks",
                column: "HisTTeamMembersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HisTTasks");

            migrationBuilder.DropTable(
                name: "HisPProjects");

            migrationBuilder.DropTable(
                name: "HisTTeamMembers");
        }
    }
}

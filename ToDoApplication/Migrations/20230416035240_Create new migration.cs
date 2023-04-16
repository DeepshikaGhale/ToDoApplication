using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApplication.Migrations
{
    public partial class Createnewmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompletionDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ID", "CompletionDate", "IsComplete", "Title" },
                values: new object[] { 1, null, false, "Prepare Breakfast" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ID", "CompletionDate", "IsComplete", "Title" },
                values: new object[] { 2, null, false, "Eat" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ID", "CompletionDate", "IsComplete", "Title" },
                values: new object[] { 3, null, false, "Clean Room" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}

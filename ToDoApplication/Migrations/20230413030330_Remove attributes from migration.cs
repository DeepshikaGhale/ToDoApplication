using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoApplication.Migrations
{
    public partial class Removeattributesfrommigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Title", "CompletionDate", "IsComplete" },
                values: new object[] { "Clean Room", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Title", "CompletionDate", "IsComplete" },
                values: new object[] { "Do Laundry", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Title", "CompletionDate", "IsComplete" },
                values: new object[] { "Eat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Title", "CompletionDate", "IsComplete" },
                values: new object[] { "Prepare Breakfast", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}

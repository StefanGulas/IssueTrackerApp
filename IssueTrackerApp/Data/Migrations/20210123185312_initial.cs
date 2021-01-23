using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IssueTrackerApp.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Due = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Severity = table.Column<int>(nullable: false),
                    IsRepoducible = table.Column<int>(nullable: false),
                    Reporter = table.Column<string>(nullable: true),
                    Responsible = table.Column<string>(nullable: true),
                    Supporting = table.Column<string>(nullable: true),
                    Customer = table.Column<string>(nullable: true),
                    Product = table.Column<string>(nullable: true),
                    Team = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issue", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Issue");
        }
    }
}

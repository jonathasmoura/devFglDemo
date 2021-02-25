using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devFglDemo.Infra.Migrations
{
    public partial class InitialCreateDemo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    ActivationDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 883, DateTimeKind.Utc).AddTicks(5344)),
                    InactivationDate = table.Column<DateTime>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 884, DateTimeKind.Utc).AddTicks(380)),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

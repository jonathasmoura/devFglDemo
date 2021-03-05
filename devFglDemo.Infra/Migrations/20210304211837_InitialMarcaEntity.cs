using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devFglDemo.Infra.Migrations
{
    public partial class InitialMarcaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 786, DateTimeKind.Utc).AddTicks(4377),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 884, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActivationDate",
                table: "User",
                nullable: true,
                defaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 785, DateTimeKind.Utc).AddTicks(9431),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 883, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    ActivationDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 789, DateTimeKind.Utc).AddTicks(2250)),
                    InactivationDate = table.Column<DateTime>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 789, DateTimeKind.Utc).AddTicks(3623)),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 884, DateTimeKind.Utc).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 786, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActivationDate",
                table: "User",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2021, 2, 25, 12, 2, 13, 883, DateTimeKind.Utc).AddTicks(5344),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2021, 3, 4, 21, 18, 36, 785, DateTimeKind.Utc).AddTicks(9431));
        }
    }
}

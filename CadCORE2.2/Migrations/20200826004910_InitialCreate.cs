using Microsoft.EntityFrameworkCore.Migrations;

namespace CadCORE2._2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Nascimento",
                table: "Users",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Salario",
                table: "Users",
                type: "varchar(250)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Nascimento",
                table: "Users",
                type: "varchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AddColumn<string>(
                name: "Data",
                table: "Users",
                type: "varchar(250)",
                nullable: true);
        }
    }
}

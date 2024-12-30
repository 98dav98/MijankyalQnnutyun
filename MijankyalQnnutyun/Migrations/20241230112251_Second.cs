using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MijankyalQnnutyun.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<char>(
                name: "NSF",
                table: "Students",
                type: "character(1)",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "char",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "City",
                table: "Students",
                type: "character(1)",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "char",
                oldNullable: true);

            migrationBuilder.AddColumn<char>(
                name: "TestColumn",
                table: "Students",
                type: "char",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestColumn",
                table: "Students");

            migrationBuilder.AlterColumn<char>(
                name: "NSF",
                table: "Students",
                type: "char",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<char>(
                name: "City",
                table: "Students",
                type: "char",
                nullable: true,
                oldClrType: typeof(char),
                oldType: "character(1)",
                oldNullable: true);
        }
    }
}

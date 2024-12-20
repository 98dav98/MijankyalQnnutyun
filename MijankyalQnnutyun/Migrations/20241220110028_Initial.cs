using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MijankyalQnnutyun.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Learning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    ScholarshipAmount = table.Column<int>(type: "integer", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: true),
                    Speciality = table.Column<char>(type: "char", nullable: true),
                    Group = table.Column<char>(type: "char", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Learning_pkey", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    NumberOfSeats = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<char>(type: "char", nullable: true),
                    Dekan = table.Column<char>(type: "char", nullable: true),
                    LearningId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Faculty_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "LearningId",
                        column: x => x.LearningId,
                        principalTable: "Learning",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityAlwaysColumn),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    YearOfEnrollment = table.Column<DateOnly>(type: "date", nullable: true),
                    NSF = table.Column<char>(type: "char", nullable: true),
                    City = table.Column<char>(type: "char", nullable: true),
                    LearningId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Students_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "LearningId",
                        column: x => x.LearningId,
                        principalTable: "Learning",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_LearningId",
                table: "Faculty",
                column: "LearningId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_LearningId",
                table: "Students",
                column: "LearningId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Learning");
        }
    }
}

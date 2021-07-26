using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_JunJobs.Data.Migrations
{
    public partial class NewColumnVacancy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VacancyAboutCompany",
                table: "Vacancy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VacancyContacts",
                table: "Vacancy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VacancyMainSkills",
                table: "Vacancy",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VacancyResposibilities",
                table: "Vacancy",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VacancyAboutCompany",
                table: "Vacancy");

            migrationBuilder.DropColumn(
                name: "VacancyContacts",
                table: "Vacancy");

            migrationBuilder.DropColumn(
                name: "VacancyMainSkills",
                table: "Vacancy");

            migrationBuilder.DropColumn(
                name: "VacancyResposibilities",
                table: "Vacancy");
        }
    }
}

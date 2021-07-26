using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_JunJobs.Data.Migrations
{
    public partial class CvAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CvName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvWorkExperience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvHardSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvEducation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvContacs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CvLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CV", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CV");
        }
    }
}

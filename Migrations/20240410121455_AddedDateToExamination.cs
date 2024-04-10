using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalExaminationWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedDateToExamination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "date",
                table: "Examinations",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "Examinations");
        }
    }
}

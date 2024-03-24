using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalExaminationWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ChangedExaminationParameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "property4",
                table: "Examinations",
                newName: "homocystein");

            migrationBuilder.RenameColumn(
                name: "property3",
                table: "Examinations",
                newName: "glucosed_hymoglobin");

            migrationBuilder.RenameColumn(
                name: "property2",
                table: "Examinations",
                newName: "glucose");

            migrationBuilder.RenameColumn(
                name: "property1",
                table: "Examinations",
                newName: "createnin");

            migrationBuilder.AddColumn<int>(
                name: "c_reactive_protein",
                table: "Examinations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cholesterol",
                table: "Examinations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "c_reactive_protein",
                table: "Examinations");

            migrationBuilder.DropColumn(
                name: "cholesterol",
                table: "Examinations");

            migrationBuilder.RenameColumn(
                name: "homocystein",
                table: "Examinations",
                newName: "property4");

            migrationBuilder.RenameColumn(
                name: "glucosed_hymoglobin",
                table: "Examinations",
                newName: "property3");

            migrationBuilder.RenameColumn(
                name: "glucose",
                table: "Examinations",
                newName: "property2");

            migrationBuilder.RenameColumn(
                name: "createnin",
                table: "Examinations",
                newName: "property1");
        }
    }
}

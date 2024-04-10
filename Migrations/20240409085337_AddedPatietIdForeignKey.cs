using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalExaminationWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedPatietIdForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "patient_id",
                table: "Examinations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_patient_id",
                table: "Examinations",
                column: "patient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Examinations_Patients_patient_id",
                table: "Examinations",
                column: "patient_id",
                principalTable: "Patients",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Examinations_Patients_patient_id",
                table: "Examinations");

            migrationBuilder.DropIndex(
                name: "IX_Examinations_patient_id",
                table: "Examinations");

            migrationBuilder.DropColumn(
                name: "patient_id",
                table: "Examinations");
        }
    }
}

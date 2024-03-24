using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicalExaminationWebApi.Migrations
{
    /// <inheritdoc />
    public partial class AddedExaminationDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    property1 = table.Column<int>(type: "integer", nullable: false),
                    property2 = table.Column<int>(type: "integer", nullable: false),
                    property3 = table.Column<int>(type: "integer", nullable: false),
                    property4 = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examinations");
        }
    }
}

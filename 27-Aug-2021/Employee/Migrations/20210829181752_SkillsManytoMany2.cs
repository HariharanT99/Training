using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeProject.Migrations
{
    public partial class SkillsManytoMany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillsSkillId",
                table: "EmployeeSkill");

            migrationBuilder.RenameColumn(
                name: "SkillsSkillId",
                table: "EmployeeSkill",
                newName: "SklSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkill_SkillsSkillId",
                table: "EmployeeSkill",
                newName: "IX_EmployeeSkill_SklSkillId");

            migrationBuilder.AddColumn<string>(
                name: "SkillName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Skills_SklSkillId",
                table: "EmployeeSkill",
                column: "SklSkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeSkill_Skills_SklSkillId",
                table: "EmployeeSkill");

            migrationBuilder.DropColumn(
                name: "SkillName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "SklSkillId",
                table: "EmployeeSkill",
                newName: "SkillsSkillId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeSkill_SklSkillId",
                table: "EmployeeSkill",
                newName: "IX_EmployeeSkill_SkillsSkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeSkill_Skills_SkillsSkillId",
                table: "EmployeeSkill",
                column: "SkillsSkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

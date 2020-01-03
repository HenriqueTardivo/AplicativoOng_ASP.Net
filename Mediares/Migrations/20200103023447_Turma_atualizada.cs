using Microsoft.EntityFrameworkCore.Migrations;

namespace Mediares.Migrations
{
    public partial class Turma_atualizada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turma_Disciplina_DisciplinaID",
                table: "Turma");

            migrationBuilder.RenameColumn(
                name: "DisciplinaID",
                table: "Turma",
                newName: "DisciplinaId");

            migrationBuilder.RenameIndex(
                name: "IX_Turma_DisciplinaID",
                table: "Turma",
                newName: "IX_Turma_DisciplinaId");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaId",
                table: "Turma",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeTurma",
                table: "Turma",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Turma_Disciplina_DisciplinaId",
                table: "Turma",
                column: "DisciplinaId",
                principalTable: "Disciplina",
                principalColumn: "DisciplinaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Turma_Disciplina_DisciplinaId",
                table: "Turma");

            migrationBuilder.DropColumn(
                name: "NomeTurma",
                table: "Turma");

            migrationBuilder.RenameColumn(
                name: "DisciplinaId",
                table: "Turma",
                newName: "DisciplinaID");

            migrationBuilder.RenameIndex(
                name: "IX_Turma_DisciplinaId",
                table: "Turma",
                newName: "IX_Turma_DisciplinaID");

            migrationBuilder.AlterColumn<int>(
                name: "DisciplinaID",
                table: "Turma",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Turma_Disciplina_DisciplinaID",
                table: "Turma",
                column: "DisciplinaID",
                principalTable: "Disciplina",
                principalColumn: "DisciplinaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

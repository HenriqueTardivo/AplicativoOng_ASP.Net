using Microsoft.EntityFrameworkCore.Migrations;

namespace Mediares.Migrations
{
    public partial class reupload_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "DisciplinaID",
                table: "Disciplina",
                newName: "DisciplinaId");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaId",
                table: "Aluno",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno");

            migrationBuilder.RenameColumn(
                name: "DisciplinaId",
                table: "Disciplina",
                newName: "DisciplinaID");

            migrationBuilder.AlterColumn<int>(
                name: "TurmaId",
                table: "Aluno",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Turma_TurmaId",
                table: "Aluno",
                column: "TurmaId",
                principalTable: "Turma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

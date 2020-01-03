using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediares.Models
{
	public class Turma
	{
		public int Id { get; set; }
		public string NomeTurma { get; set; }
		public int CargaHoraria { get; set; }
		public Disciplina Disciplina { get; set; }
		public int DisciplinaId { get; set; }
		public ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

		public Turma()
		{
		}

		public Turma(int id, int cargaHoraria, Disciplina disciplina)
		{
			Id = id;
			CargaHoraria = cargaHoraria;
			Disciplina = disciplina;
		}

		public void AddAluno(Aluno aluno)
		{
			Alunos.Add(aluno);
		}

		public void RemoveAluno (Aluno aluno)
		{
			Alunos.Remove(aluno);
		}
	}
}

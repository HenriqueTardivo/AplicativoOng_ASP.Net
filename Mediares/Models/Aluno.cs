using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediares.Models
{
	public class Aluno
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Telefone { get; set; }
		public int TurmaId { get; set; }
		public Turma Turma { get; set; }


		public Aluno()
		{

		}

		public Aluno(int id, string nome, string telefone, Turma turma)
		{
			Id = id;
			Nome = nome;
			Telefone = telefone;
			Turma = turma;
		}
	}

}

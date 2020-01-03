using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediares.Models
{
	public class Disciplina
	{
		public int DisciplinaID { get; set; }
		public string Nome { get; set; }


		public Disciplina()
		{
		}

		public Disciplina(int disciplinaID, string nome)
		{
			DisciplinaID = disciplinaID;
			Nome = nome;
		}
	}
	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Mediares.Models.ViewModels
{
	public class TurmaFormularioDeCadastro
	{
		public Turma Turma { get; set; }
		public ICollection<Disciplina> Disciplinas { get; set; }
	}
}

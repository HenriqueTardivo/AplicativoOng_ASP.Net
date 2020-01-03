using Mediares.Data;
using Mediares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediares.Services
{
	public class DisciplinaService
	{
		private readonly MediaresContext _context;

		public DisciplinaService(MediaresContext context)
		{
			_context = context;
		}


		public List<Disciplina> FindAll()
		{
			return _context.Disciplina.OrderBy(x => x.Nome).ToList();
		}
	}

}

using Mediares.Data;
using Mediares.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mediares.Services
{
	public class TurmaService
	{
		private readonly MediaresContext _context;

		public TurmaService (MediaresContext context)
		{
			_context = context;
		}

		public List<Turma> FindAll()
		{
			return _context.Turma.ToList();
		}
		public void Insert(Turma obj)
		{
			_context.Add(obj);
			_context.SaveChanges();
		}
	}
}

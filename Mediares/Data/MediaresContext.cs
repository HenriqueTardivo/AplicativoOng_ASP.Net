using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mediares.Models;

namespace Mediares.Data
{
    public class MediaresContext : DbContext
    {
        public MediaresContext (DbContextOptions<MediaresContext> options)
            : base(options)
        {
        }

        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Turma> Turma { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notas.Models;

namespace Notas.Data
{
    public class NotasContext : DbContext
    {
        public NotasContext (DbContextOptions<NotasContext> options)
            : base(options)
        {
        }

        public DbSet<Notas.Models.Aluno> Aluno { get; set; } = default!;
    }
}

using GerenciamentoAlunos.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoAlunos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
    }
}

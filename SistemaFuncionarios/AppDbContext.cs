using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionarios
{
    public class AppDbContext : DbContext
    {
        public DbSet<Profissional> Profissionais { get; set; }

        public AppDbContext() : base("name=DefaultConnection")
        {
        }
    }
}

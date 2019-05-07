using Microsoft.EntityFrameworkCore;
using ProjetoEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEF.Database
{
    public class ApplicationDbContext :DbContext
    {

       public DbSet<Funcionario> Funcionarios { get; set; }
       public DbSet<Categoria> Categoria { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

    }
}

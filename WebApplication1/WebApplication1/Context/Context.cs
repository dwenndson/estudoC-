using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class Context : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }


    }
}

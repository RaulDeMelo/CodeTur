using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace Senai.CodeTur.Servico.Contextos
{
    public class CodeTurContext : DbContext
    {
        public DbSet<UsuarioDominio> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuild)
        {
            optionsBuilder.UseSqlServer("Data Source=\\sqlexpress");

            base.OnConfiguring(optionsBuilder);
        }
    }
}

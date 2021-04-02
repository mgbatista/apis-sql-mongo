using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proj1_BancoDeDados.Models;

    public class CompraContext : DbContext
    {
        public CompraContext (DbContextOptions<CompraContext> options)
            : base(options)
        {
        }

        public DbSet<Proj1_BancoDeDados.Models.Cliente> Cliente { get; set; }

        public DbSet<Proj1_BancoDeDados.Models.Endereco> Endereco { get; set; }
    }

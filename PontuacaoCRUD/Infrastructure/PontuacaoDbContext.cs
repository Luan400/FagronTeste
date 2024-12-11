using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontuacaoCRUD.Entitites;
using PontuacaoCRUD.Models;

namespace PontuacaoCRUD.Infrastructure
{
    public class PontuacaoDbContext : DbContext 
    {
       public DbSet<Jogo> Jogos { get; set; }  
       public DbSet<Resultados> Resultados { get; set; }

         public PontuacaoDbContext(DbContextOptions<PontuacaoDbContext> options)  : base(options) 
        {

        }

        
    }
}
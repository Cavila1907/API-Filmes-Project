using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext //Contexto com o banco de dados
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base (opt)
        {

        }

        public DbSet <Filme> Filmes { get; set; }
    }
}

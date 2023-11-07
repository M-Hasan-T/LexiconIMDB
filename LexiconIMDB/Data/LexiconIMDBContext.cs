using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconIMDB.Models.Entities;

namespace LexiconIMDB.Data
{
    public class LexiconIMDBContext : DbContext
    {
        public LexiconIMDBContext (DbContextOptions<LexiconIMDBContext> options)
            : base(options)
        {
        }

        public DbSet<LexiconIMDB.Models.Entities.Movie> Movie { get; set; } = default!;
    }
}

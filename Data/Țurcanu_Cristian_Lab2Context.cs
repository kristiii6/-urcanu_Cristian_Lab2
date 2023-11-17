using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Țurcanu_Cristian_Lab2.Models;

namespace Țurcanu_Cristian_Lab2.Data
{
    public class Țurcanu_Cristian_Lab2Context : DbContext
    {
        public Țurcanu_Cristian_Lab2Context (DbContextOptions<Țurcanu_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Țurcanu_Cristian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Țurcanu_Cristian_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}

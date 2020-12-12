using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Kovacs_Gyongyi_Elisabeta_Lab8.Models;

namespace Kovacs_Gyongyi_Elisabeta_Lab8.Data
{
    public class Kovacs_Gyongyi_Elisabeta_Lab8Context : DbContext
    {
        public Kovacs_Gyongyi_Elisabeta_Lab8Context (DbContextOptions<Kovacs_Gyongyi_Elisabeta_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Lab8.Models.Book> Book { get; set; }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Kovacs_Gyongyi_Elisabeta_Lab8.Models.Category> Category { get; set; }
    }
}

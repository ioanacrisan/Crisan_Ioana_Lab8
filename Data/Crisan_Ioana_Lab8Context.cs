using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crisan_Ioana_Lab8.Models;

namespace Crisan_Ioana_Lab8.Data
{
    public class Crisan_Ioana_Lab8Context : DbContext
    {
        public Crisan_Ioana_Lab8Context (DbContextOptions<Crisan_Ioana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Crisan_Ioana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Crisan_Ioana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Crisan_Ioana_Lab8.Models.Category> Category { get; set; }
    }
}

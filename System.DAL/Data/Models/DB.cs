using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.DAL
{
    public class DB : DbContext
    {
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Ticket> Tickets => Set<Ticket>();
        public DbSet<Developer> Developers => Set<Developer>();

        public DB(DbContextOptions<DB> options) : base(options) { }

    }
}

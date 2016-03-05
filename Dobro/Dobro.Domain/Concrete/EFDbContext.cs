using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Dobro.Domain.Entities;

namespace Dobro.Domain.Concrete
{
    public class EFDbContext : DbContext
    {

        public DbSet<Doing> Doings { get; set; }

    }
}

#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EAF.Models;

namespace EAF.Data
{
    public class EAFContext : DbContext
    {
        public EAFContext (DbContextOptions<EAFContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}

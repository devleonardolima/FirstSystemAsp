using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstSystemAsp.Models
{
    public class FirstSystemAspContext : DbContext
    {
        public FirstSystemAspContext (DbContextOptions<FirstSystemAspContext> options)
            : base(options)
        {
        }

        public DbSet<FirstSystemAsp.Models.Department> Department { get; set; }
    }
}

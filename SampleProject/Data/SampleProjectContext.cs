using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleProject.Model;

namespace SampleProject.Data
{
    public class SampleProjectContext : DbContext
    {
        public SampleProjectContext (DbContextOptions<SampleProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SampleProject.Model.Class> Class { get; set; } = default!;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BagiTugas.Models;

namespace BagiTugas.Data
{
    public class BagiTugasContext : DbContext
    {
        public BagiTugasContext (DbContextOptions<BagiTugasContext> options)
            : base(options)
        {
        }

        public DbSet<BagiTugas.Models.Course> Course { get; set; }
    }
}

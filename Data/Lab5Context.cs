using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab05.Models
{
    public class Lab05Context : DbContext
    {
        public Lab05Context (DbContextOptions<Lab05Context> options)
            : base(options)
        {
        }

        public DbSet<Lab05.Models.Movie> Movie { get; set; }
    }
}

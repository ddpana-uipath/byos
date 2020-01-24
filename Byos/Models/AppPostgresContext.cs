using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Models
{
    public class AppPostgresContext : DbContext
    {
        public AppPostgresContext(DbContextOptions<AppPostgresContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

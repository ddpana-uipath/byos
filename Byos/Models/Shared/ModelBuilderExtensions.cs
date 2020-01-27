using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        Name = "Daniel Pana",
                        Department = Dept.IT,
                        Email = "karo@webi.ro",
                        Password = "test"
                    }
                );
        }
    }
}
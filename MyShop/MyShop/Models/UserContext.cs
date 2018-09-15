using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyShop.Models
{
    public sealed class UserContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options):base (options)
        {
            Database.EnsureCreated();
        }
    }
}

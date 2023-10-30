using BD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Data
{
    public class BDContext : DbContext
    {

        public BDContext(DbContextOptions<BDContext> options) : base(options)
        {
            
        }
        

        //tabelas

        public DbSet<Comments> Comments { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Creator> Creator { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}

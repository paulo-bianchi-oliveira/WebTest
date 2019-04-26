using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class DbCtx : DbContext
    {
        public DbCtx(DbContextOptions<DbCtx> options) : base(options)
        {

        }

        public DbSet<Models.User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }

}

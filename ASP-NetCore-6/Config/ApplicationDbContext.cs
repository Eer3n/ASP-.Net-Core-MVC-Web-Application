using ASP_NetCore_6.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASP_NetCore_6.Config;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
      
   } 
   public DbSet<User> NET_USER { get; set; }
}

// DB connection class
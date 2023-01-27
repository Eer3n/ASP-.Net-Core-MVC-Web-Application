using Microsoft.EntityFrameworkCore;

namespace ASP_NetCore_6.Config;

public class ApplicationDbContext : DbContext
{
   public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
   {
      
   } 
}
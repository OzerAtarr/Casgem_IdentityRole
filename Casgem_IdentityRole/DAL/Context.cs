using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casgem_IdentityRole.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FCHRJ42\SQLEXPRESS;initial Catalog=CasgemDbRole; integrated security=true;trust server certificate=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}

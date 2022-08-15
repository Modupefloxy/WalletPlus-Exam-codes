using Microsoft.EntityFrameworkCore;
using WalletPlus_Inc.Web.DATA.Entities;

namespace WalletPlus_Inc.Web.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
            public DbSet <Customers> Customers { get; set; }
        
    }
}

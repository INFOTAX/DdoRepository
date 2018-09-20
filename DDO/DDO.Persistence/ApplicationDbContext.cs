
using DDO.Domain.Accounting;
using DDO.Domain.SupplierModule;
using DDO.Domain.TdsModule;
using Microsoft.EntityFrameworkCore;

namespace DDO.Persistence
{
    public class ApplicationDbContext : DbContext
    {
    
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base((DbContextOptions)options)

        {
        }
        public DbSet<Tds> Tdss {get; set;}
         public DbSet<AccountingUnit> AccountingUnits { get; set; }
         public DbSet<Supplier> Suppliers { get; set; }

    }
}
using Fortuna.Data.Entities.Asset;
using Fortuna.Data.Entities.Common;
using Fortuna.Data.Entities.Expense;
using Microsoft.EntityFrameworkCore;

namespace Fortuna.Data.DbContenxt
{
    public class FortunaDbContext : DbContext
    {
        public FortunaDbContext(DbContextOptions<FortunaDbContext> options) : base(options) { }

        public DbSet<Expense> Expense { get; set; }
        public DbSet<ExpenseType> ExpenseType { get; set; }
        public DbSet<ExpenseItemType> ExpenseItemType { get; set; }
        public DbSet<Asset> Asset { get; set; }
        public DbSet<AssetType> AssetType { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<QuantityType>QuantityType { get; set; }
        public DbSet<Store> Store { get; set; }
    }
}

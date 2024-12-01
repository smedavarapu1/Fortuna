using Fortuna.Data.Entities.Asset;
using Fortuna.Data.Entities.Common;
using Fortuna.Data.Entities.Expense;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortuna.Data.DbContenxt
{
    public class FortunaDbContext : DbContext
    {
        public FortunaDbContext(DbContextOptions<FortunaDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}

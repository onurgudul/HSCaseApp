using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Configuration.LazyLoadingEnabled = false;

        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<CostOfFuture> CostOfFutures { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CostOfFuture>()
                  .HasRequired<Expense>(e => e.Expense)
                  .WithMany(c => c.CostOfFutures)
                 .HasForeignKey<int>(e => e.ExpenseId);
        }
    }
}

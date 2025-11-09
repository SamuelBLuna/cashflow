using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    public CashFlowDbContext(DbContextOptions dbContext) : base(dbContext) { }

    public DbSet<Expense> Expenses { get; set; }    
    public DbSet<User> Users { get; set; }    
}

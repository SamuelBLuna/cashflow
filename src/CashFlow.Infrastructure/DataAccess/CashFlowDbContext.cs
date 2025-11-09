using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

internal class CashFlowDbContext : DbContext
{
    private readonly DbContextOptions _dbContext;
    public CashFlowDbContext(DbContextOptions dbContext) : base(dbContext) { }

    public DbSet<Expense> Expenses { get; set; }
    
}

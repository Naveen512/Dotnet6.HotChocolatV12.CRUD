using Dot6.HotChoco12.GraphQL.CRUD.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot6.HotChoco12.GraphQL.CRUD.Demo.Data;

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {
 
    }
    public DbSet<Cake> Cake { get; set; }
}
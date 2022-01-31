using Dot6.HotChoco12.GraphQL.CRUD.Demo.Data;
using Dot6.HotChoco12.GraphQL.CRUD.Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dot6.HotChoco12.GraphQL.CRUD.Demo.GqlTypes;

public class QueryType
{
    public async Task<List<Cake>> AllCakesAsync([Service] MyWorldDbContext context) 
    { 
        return await context.Cake.ToListAsync();
    }
}
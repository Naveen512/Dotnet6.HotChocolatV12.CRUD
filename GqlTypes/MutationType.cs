using Dot6.HotChoco12.GraphQL.CRUD.Demo.Data;
using Dot6.HotChoco12.GraphQL.CRUD.Demo.Data.Entities;

namespace Dot6.HotChoco12.GraphQL.CRUD.Demo.GqlTypes;

public class MutationType
{
    public async Task<Cake> SaveCakeAsync([Service] MyWorldDbContext context,
    Cake newCake)
    {
        context.Cake.Add(newCake);
        await context.SaveChangesAsync();
        return newCake;
    }

    public async Task<Cake> UpdateCakeAsync([Service] MyWorldDbContext context, Cake updateCake)
    {
        context.Cake.Update(updateCake);
        await context.SaveChangesAsync();
        return updateCake;
    }

    public async Task<string> DeleteCakeAsync([Service] MyWorldDbContext context, int id)
    {
        var cakeToDelete = await context.Cake.FindAsync(id);
        if (cakeToDelete == null)
        {
            return "Invalid Operation";
        }
        context.Cake.Remove(cakeToDelete);
        await context.SaveChangesAsync();
        return "Record Deleted!";
    }
}
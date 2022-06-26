using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly PlanManagerDbContext _dbContext;
    public UserRepository(PlanManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    //Interrogation to point out the return of a null value
    public Plan? GetUserById(Guid id)
    {
        return _dbContext.Plans.Find(id);
    }
}
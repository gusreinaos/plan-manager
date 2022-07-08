using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Infrastructure.Repositories;

public class PlanRepository : IPlanRepository
{
    private readonly PlanManagerDbContext _dbContext;
    public PlanRepository(PlanManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    //Interrogation to point out the return of a null value
    public Plan? GetPlanById(Guid planId)
    {
        return _dbContext.Plans.Find(planId);
    }
    
    
}
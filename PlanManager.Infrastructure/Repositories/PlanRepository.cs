using Microsoft.EntityFrameworkCore;
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


    public IEnumerable<Plan> GetPlans()
    {
        return _dbContext.Plans.ToList();
    }

    public IEnumerable<Plan> GetPlansByUserId(Guid userId)
    {
        return _dbContext.Plans.Where(p => p.UserId.Equals(userId));
    }
    public Plan? GetPlanById(Guid planId)
    {
        return _dbContext.Plans.Find(planId);
    }

    public void CreatePlan(Plan plan)
    {
        _dbContext.Plans.Add(plan);
    }
    
    public void DeletePlan(Guid planId)
    {
        Plan? plan = _dbContext.Plans.Find(planId);
        _dbContext.Plans.Remove(plan);
    }

    public void UpdatePlan(Plan plan)
    {
        _dbContext.Entry(plan).State = EntityState.Modified;
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}
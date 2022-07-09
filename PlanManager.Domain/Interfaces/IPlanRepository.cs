using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IPlanRepository
{
    public IEnumerable<Plan> GetPlans();
    public IEnumerable<Plan> GetPlanByUserId(Guid userId);
    public Plan GetPlanById(Guid planId);
    public void CreatePlan(Plan plan);
    public void DeletePlan(Guid planId);
    public void UpdatePlan(Plan plan);
    public void Save();
}
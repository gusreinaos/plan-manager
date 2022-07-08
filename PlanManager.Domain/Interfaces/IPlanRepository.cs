using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IPlanRepository
{
    public Plan GetPlanById(Guid planId);
}
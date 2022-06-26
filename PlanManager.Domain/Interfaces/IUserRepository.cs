using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserRepository
{
    public Plan GetUserById(Guid id);
}
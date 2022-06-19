using PlanManager.Domain.Interfaces;

namespace PlanManager.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public string GetUser()
    {
        return "Oscar";
    }
}
using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserRepository
{
    public User? GetUserById(Guid id);
    public IEnumerable<User> GetUsers();
    public void CreateUser(User user);
    public void DeleteUser(User user);
    public void UpdateUser(User user);
    public void Save();
}
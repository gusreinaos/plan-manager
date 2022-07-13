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
    public User? GetUserById(Guid id)
    {
        return _dbContext.Users.Find(id);
    }

    public User? GetUserByMail(string mail)
    {
        return _dbContext.Users.Find(mail);
    }

    public IEnumerable<User> GetUsers()
    {
        throw new NotImplementedException();
    }

    public void CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
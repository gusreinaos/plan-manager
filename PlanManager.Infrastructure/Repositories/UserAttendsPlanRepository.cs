using Microsoft.EntityFrameworkCore;
using PlanManager.Domain.Entities;
using PlanManager.Domain.Interfaces;

namespace PlanManager.Infrastructure.Repositories;

public class UserAttendsPlanRepository : IUserAttendsPlanRepository
{
    private readonly PlanManagerDbContext _dbContext;
    public UserAttendsPlanRepository(PlanManagerDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public IEnumerable<UserAttendsPlan> GetUserAttendsPlanById()
    {
        throw new NotImplementedException();
    }

    public void CreateUserAttendsPlan(UserAttendsPlan userAttendsPlan)
    {
        _dbContext.UserAttendsPlan.Add(userAttendsPlan);
    }

    public void DeleteUserAttendsPlan(int userAttendsPlanId)
    {
        var userAttendsPlan = _dbContext.UserAttendsPlan.Find(userAttendsPlanId);
        if (userAttendsPlan != null) _dbContext.UserAttendsPlan.Remove(userAttendsPlan);
    }

    public void UpdateUserAttendsPlan(UserAttendsPlan userAttendsPlan)
    {
        _dbContext.Entry(userAttendsPlan).State = EntityState.Modified;
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}
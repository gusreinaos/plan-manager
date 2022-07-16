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
    
    public UserAttendsPlan GetUserAttendsPlanById(int Id)
    {
        throw new NotImplementedException();
    }

    public UserAttendsPlan? GetUserAttendsPlanByUserIdAndPlanId(Guid userId, Guid planId)
    {
        return _dbContext.UserAttendsPlan.FirstOrDefault(x => x.UserId.Equals(userId) && x.PlanId.Equals(planId));
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
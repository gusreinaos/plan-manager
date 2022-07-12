using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserAttendsPlanRepository
{
    public IEnumerable<UserAttendsPlan> GetUserAttendsPlan();
    public void CreateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void DeleteUserAttendsPlan(Guid planId);
    public void UpdateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void Save();
}
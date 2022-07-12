using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserAttendsPlanRepository
{
    public IEnumerable<UserAttendsPlan> GetUserAttendsPlanById();
    public void CreateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void DeleteUserAttendsPlan(int userAttendsPlanId);
    public void UpdateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void Save();
}
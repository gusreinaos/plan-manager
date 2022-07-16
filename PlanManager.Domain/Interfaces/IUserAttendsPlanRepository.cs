using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserAttendsPlanRepository
{
    public UserAttendsPlan GetUserAttendsPlanById(int Id);
    public UserAttendsPlan? GetUserAttendsPlanByUserIdAndPlanId(Guid userId, Guid planId);
    public void CreateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void DeleteUserAttendsPlan(int userAttendsPlanId);
    public void UpdateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void Save();
}
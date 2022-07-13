using PlanManager.Domain.Entities;

namespace PlanManager.Domain.Interfaces;

public interface IUserAttendsPlanRepository
{
    public UserAttendsPlan GetUserAttendsPlanById();
    public UserAttendsPlan GetUserAttendsPlanByPlanId(Guid planId);
    public void CreateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void DeleteUserAttendsPlan(int userAttendsPlanId);
    public void UpdateUserAttendsPlan(UserAttendsPlan userAttendsPlan);
    public void Save();
}
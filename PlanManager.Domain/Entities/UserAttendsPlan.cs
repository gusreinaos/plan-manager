namespace PlanManager.Domain.Entities;

public class UserAttendsPlan
{
    public UserAttendsPlan(int id, Guid userId, Guid planId, string status)
    {
        Id = id;
        UserId = userId;
        PlanId = planId;
        Status = status;

    }

    public int Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid PlanId { get; set; }
    public Plan Plan { get; set; }
    public string Status { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace PlanManager.Domain.Entities;
public class Plan
{
    public Plan(Guid id, string name, double longitude, double latitude, string description, Guid userId)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
        UserId = userId;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }
    
    //Navigation Properties
    
    public User User { get; set; }
    public Guid UserId { get; set; }
    public List<UserAttendsPlan> UserAttendsPlans { get; set; }
    
    //public List<UserPlan> InvitedUsers { get; set; }
}

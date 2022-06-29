namespace PlanManager.Domain.Entities;
public class Plan
{
    

    public Plan(Guid id, string name, /*User ownerId, List<User> invitedUsersId*/ double longitude, double latitude, string description)
    {
        Id = id;
        Name = name;
        //OwnerId = ownerId;
        //InvitedUsersId = invitedUsersId;
        Longitude = longitude;
        Latitude = latitude;
        Description = description;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    //public User OwnerId { get; set; }
    //public List<User> InvitedUsersId { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public string Description { get; set; }
}

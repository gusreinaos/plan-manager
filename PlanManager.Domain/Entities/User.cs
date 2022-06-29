namespace PlanManager.Domain.Entities;

public class User
{
    public User(Guid id, string fullName, string email, string password)
    {
        Id = id;
        FullName = fullName;
        Email = email;
        Password = password;
    }

    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    //public List<Plan> CreatedPlansIds { get; set; }
    //public List<Plan> AttendingPlansIds { get; set; }
    
    
}
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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
    
    //Navigation Properties

    public List<Plan> Plans { get; set; }
    public List<UserAttendsPlan> UserAttendsPlans { get; set; }



}
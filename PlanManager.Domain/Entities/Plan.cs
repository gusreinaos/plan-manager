namespace PlanManager.Domain.Entities;

public class Plan
{
    public Guid Id;
    public string Name;
    public Guid OwnerId; //Unique identifier 
    public DateTime Date;
    public string Latitude;
    public string Longitude;
    public string Description;

    public Plan(string name)
    {
        Name = name;
    }
}

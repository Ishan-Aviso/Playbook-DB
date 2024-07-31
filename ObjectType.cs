public class ObjectType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Constructor
    public ObjectType() { }

    // Overloaded Constructor
    public ObjectType(int id, string name, string description, bool isDeleted, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    // Getter and Setter methods
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }

    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }

    public string GetDescription() { return Description; }
    public void SetDescription(string description) { Description = description; }

    public bool GetIsDeleted() { return IsDeleted; }
    public void SetIsDeleted(bool isDeleted) { IsDeleted = isDeleted; }

    public DateTime GetCreatedAt() { return CreatedAt; }
    public void SetCreatedAt(DateTime createdAt) { CreatedAt = createdAt; }

    public DateTime GetUpdatedAt() { return UpdatedAt; }
    public void SetUpdatedAt(DateTime updatedAt) { UpdatedAt = updatedAt; }
}

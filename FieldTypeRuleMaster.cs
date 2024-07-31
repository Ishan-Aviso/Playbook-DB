public class FieldTypeRuleMaster
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Operation { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Constructor
    public FieldTypeRuleMaster() { }

    // Overloaded Constructor
    public FieldTypeRuleMaster(int id, string name, string operation, bool isDeleted, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Operation = operation;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    // Getter and Setter methods
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }

    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }

    public string GetOperation() { return Operation; }
    public void SetOperation(string operation) { Operation = operation; }

    public bool GetIsDeleted() { return IsDeleted; }
    public void SetIsDeleted(bool isDeleted) { IsDeleted = isDeleted; }

    public DateTime GetCreatedAt() { return CreatedAt; }
    public void SetCreatedAt(DateTime createdAt) { CreatedAt = createdAt; }

    public DateTime GetUpdatedAt() { return UpdatedAt; }
    public void SetUpdatedAt(DateTime updatedAt) { UpdatedAt = updatedAt; }
}

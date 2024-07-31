public class ObjectFieldOptions
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ObjectFieldId { get; set; }
    public string Label { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Constructor
    public ObjectFieldOptions() { }

    // Overloaded Constructor
    public ObjectFieldOptions(int id, string name, int objectFieldId, string label, bool isDeleted, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        ObjectFieldId = objectFieldId;
        Label = label;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    // Getter and Setter methods
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }

    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }

    public int GetObjectFieldId() { return ObjectFieldId; }
    public void SetObjectFieldId(int objectFieldId) { ObjectFieldId = objectFieldId; }

    public string GetLabel() { return Label; }
    public void SetLabel(string label) { Label = label; }

    public bool GetIsDeleted() { return IsDeleted; }
    public void SetIsDeleted(bool isDeleted) { IsDeleted = isDeleted; }

    public DateTime GetCreatedAt() { return CreatedAt; }
    public void SetCreatedAt(DateTime createdAt) { CreatedAt = createdAt; }

    public DateTime GetUpdatedAt() { return UpdatedAt; }
    public void SetUpdatedAt(DateTime updatedAt) { UpdatedAt = updatedAt; }
}

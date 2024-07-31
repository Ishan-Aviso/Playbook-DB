public class ObjectFields
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Label { get; set; }
    public string Type { get; set; }
    public int ObjectId { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    // Constructor
    public ObjectFields() { }

    // Overloaded Constructor
    public ObjectFields(int id, string name, string label, string type, int objectId, bool isDeleted, DateTime createdAt, DateTime updatedAt)
    {
        Id = id;
        Name = name;
        Label = label;
        Type = type;
        ObjectId = objectId;
        IsDeleted = isDeleted;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    // Getter and Setter methods
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }

    public string GetName() { return Name; }
    public void SetName(string name) { Name = name; }

    public string GetLabel() { return Label; }
    public void SetLabel(string label) { Label = label; }

    public string GetType() { return Type; }
    public void SetType(string type) { Type = type; }

    public int GetObjectId() { return ObjectId; }
    public void SetObjectId(int objectId) { ObjectId = objectId; }

    public bool GetIsDeleted() { return IsDeleted; }
    public void SetIsDeleted(bool isDeleted) { IsDeleted = isDeleted; }

    public DateTime GetCreatedAt() { return CreatedAt; }
    public void SetCreatedAt(DateTime createdAt) { CreatedAt = createdAt; }

    public DateTime GetUpdatedAt() { return UpdatedAt; }
    public void SetUpdatedAt(DateTime updatedAt) { UpdatedAt = updatedAt; }
}

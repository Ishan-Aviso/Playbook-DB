public class FieldTypeRules
{
    public int Id { get; set; }
    public int TypeId { get; set; }
    public int RuleId { get; set; }

    // Constructor
    public FieldTypeRules() { }

    // Overloaded Constructor
    public FieldTypeRules(int id, int typeId, int ruleId)
    {
        Id = id;
        TypeId = typeId;
        RuleId = ruleId;
    }

    // Getter and Setter methods
    public int GetId() { return Id; }
    public void SetId(int id) { Id = id; }

    public int GetTypeId() { return TypeId; }
    public void SetTypeId(int typeId) { TypeId = typeId; }

    public int GetRuleId() { return RuleId; }
    public void SetRuleId(int ruleId) { RuleId = ruleId; }
}

namespace apitest.Models;


public class Whish : Traceable
{
    public int Id { get; set; }
    public required Person Owner { get; set; }
    public int OwnerId { get => Owner.Id; }
    public required string GiftName { get; set; }
    public WhishStatus Status { get; set; }
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Link { get; set; }
    public bool IsPersonal { get; set; }
    public bool IsSuggested { get; set; }
    public ExpirationType ExpirationType { get; set; }
    public List<Person> Buyers { get; set; } = [];
}

public class Person : Traceable
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public DateTime Birthday { get; set; }

    public List<Whish> Whishes { get; set; } = [];
    public List<Group> Groups { get; set; } = [];
}

public class Group : Traceable
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Person> Members { get; set; } = [];
}

public enum WhishStatus
{
    Hidden,
    Open,
    BuyTogether,
    Bought,
    Cancelled,
    Expired,
}

public enum ExpirationType
{
    Birthday,
    Christmas,
    Never,
}

public class Traceable
{
    public DateTime CreatedAt { get; set; }
    public required Person CreatedBy { get; set; }
    public DateTime UpdatedAt { get; set; }
    public required Person UpdatedBy { get; set; }
}
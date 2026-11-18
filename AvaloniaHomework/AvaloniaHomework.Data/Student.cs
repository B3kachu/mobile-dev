namespace AvaloniaHomework.Data;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Nickname { get; set; } = "";
    public DateTime BirthDate { get; set; }
    public string? Phone { get; set; }              // необязательное
    public int FaceitLevel { get; set; }
    public string PreferredRole { get; set; } = "";
    public bool IsActive { get; set; }

    public List<Session> Sessions { get; set; } = new();   // занятия ученика

    public override string ToString() => $"{FullName} «{Nickname}», Faceit {FaceitLevel}, {PreferredRole}";
}
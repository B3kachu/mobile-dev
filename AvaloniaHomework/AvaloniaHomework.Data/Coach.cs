namespace AvaloniaHomework.Data;

public class Coach
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Nickname { get; set; } = "";
    public string Specialization { get; set; } = "";
    public int ExperienceYears { get; set; }
    public bool WasPro { get; set; }
    public int PricePerHour { get; set; }

    public List<Session> Sessions { get; set; } = new();   // занятия тренера

    public override string ToString() => $"{FullName} «{Nickname}», {Specialization}, {PricePerHour} ₽/ч";
}
namespace AvaloniaHomework.Data;

public class Session
{
    public int Id { get; set; }

    public int StudentId { get; set; }                 // внешний ключ
    public Student Student { get; set; } = null!;      // навигационное свойство

    public int CoachId { get; set; }                   // внешний ключ
    public Coach Coach { get; set; } = null!;          // навигационное свойство

    public DateTime StartTime { get; set; }
    public int DurationMinutes { get; set; }
    public int Price { get; set; }
    public string? Topic { get; set; }                 // необязательное
    public bool IsOnline { get; set; }

    public override string ToString() =>
        $"{StartTime:dd.MM HH:mm} — {Student?.Nickname} у {Coach?.Nickname}, {Topic ?? "без темы"}, {Price} ₽";
}
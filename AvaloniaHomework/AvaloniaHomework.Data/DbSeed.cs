namespace AvaloniaHomework.Data;

public static class DbSeed
{
    public static void Seed(AppDbContext db)
    {
        // Если записи уже есть — ничего не добавляем, чтобы не удвоить данные
        if (db.Students.Any())
            return;

        var s1 = new Student { FullName = "Артём Волков", Nickname = "w0lf", BirthDate = new DateTime(2006, 4, 12), Phone = "+7 914 111-22-33", FaceitLevel = 6, PreferredRole = "entry", IsActive = true };
        var s2 = new Student { FullName = "Даниил Ким", Nickname = "kimchi", BirthDate = new DateTime(2007, 9, 3), FaceitLevel = 4, PreferredRole = "AWP", IsActive = true };
        var s3 = new Student { FullName = "Егор Лисин", Nickname = "lis", BirthDate = new DateTime(2005, 1, 20), Phone = "+7 914 444-55-66", FaceitLevel = 8, PreferredRole = "IGL", IsActive = false };

        var c1 = new Coach { FullName = "Игорь Смирнов", Nickname = "smirk", Specialization = "тактика и IGL", ExperienceYears = 5, WasPro = true, PricePerHour = 1500 };
        var c2 = new Coach { FullName = "Олег Пак", Nickname = "pakman", Specialization = "аим", ExperienceYears = 3, WasPro = false, PricePerHour = 900 };
        var c3 = new Coach { FullName = "Никита Орлов", Nickname = "orel", Specialization = "разбор демок", ExperienceYears = 7, WasPro = true, PricePerHour = 2000 };

        db.Students.AddRange(s1, s2, s3);
        db.Coaches.AddRange(c1, c2, c3);

        db.Sessions.AddRange(
            new Session { Student = s1, Coach = c2, StartTime = new DateTime(2026, 11, 10, 18, 0, 0), DurationMinutes = 60, Price = 900, Topic = "аим", IsOnline = true },
            new Session { Student = s1, Coach = c1, StartTime = new DateTime(2026, 11, 12, 19, 0, 0), DurationMinutes = 90, Price = 2250, Topic = "раскидка гранат на Mirage", IsOnline = false },
            new Session { Student = s2, Coach = c3, StartTime = new DateTime(2026, 11, 13, 17, 0, 0), DurationMinutes = 120, Price = 4000, Topic = "разбор демки", IsOnline = true },
            new Session { Student = s3, Coach = c1, StartTime = new DateTime(2026, 11, 14, 20, 0, 0), DurationMinutes = 60, Price = 1500, IsOnline = false } // без темы
        );

        db.SaveChanges();
    }
}
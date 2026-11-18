using AvaloniaHomework.Data;
using Microsoft.EntityFrameworkCore;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine($"Файл базы: {AppDbContext.DbPath}");

using var db = new AppDbContext();
db.Database.EnsureCreated();   // создать базу и таблицы, если их нет
DbSeed.Seed(db);               // заполнить тестовыми данными

Console.WriteLine("\n=== Ученики ===");
foreach (var s in db.Students)
    Console.WriteLine(s);

Console.WriteLine("\n=== Тренеры ===");
foreach (var c in db.Coaches)
    Console.WriteLine(c);

Console.WriteLine("\n=== Занятия ===");
var sessions = db.Sessions
    .Include(s => s.Student)   // подтянуть ученика, чтобы вывести ник, а не номер
    .Include(s => s.Coach)     // подтянуть тренера
    .OrderBy(s => s.StartTime)
    .ToList();
foreach (var s in sessions)
    Console.WriteLine(s);
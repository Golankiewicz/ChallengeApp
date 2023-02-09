using ChallengeApp;

var employee = new Employee("Paweł", "Golankiewicz");
employee.AddGrade(10.4f);
employee.AddGrade(23.1f);
employee.AddGrade(5.25f);
var statistics = employee.GetStatistics();
Console.WriteLine($"Max:{ statistics.Max}");
Console.WriteLine($"Min:{ statistics.Min}");
Console.WriteLine($"Average:{ statistics.Average:N2}");

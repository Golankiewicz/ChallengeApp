using ChallengeApp;

var employee = new Employee("Paweł", "Golankiewicz");
employee.AddGrade("10,5");//string
employee.AddGrade(11.5f);//float
employee.AddGrade(11);//int
employee.AddGrade(21.85d);//double
employee.AddGrade(53l);//long
var statistics = employee.GetStatistics();
Console.WriteLine($"Max:{ statistics.Max}");
Console.WriteLine($"Min:{ statistics.Min}");
Console.WriteLine($"Average:{ statistics.Average:N2}");

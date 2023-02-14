using ChallengeApp;

var employee = new Employee("Paweł", "Golankiewicz");
employee.AddGrade("10,5");//string
employee.AddGrade(11.5f);//float
employee.AddGrade(11);//int
employee.AddGrade(21.85d);//double
employee.AddGrade(53l);//long

Console.WriteLine($"Max: {employee.GetStatistics().Max}");
Console.WriteLine($"Min: {employee.GetStatistics().Min}");
Console.WriteLine($"Average: {employee.GetStatistics().Average}");

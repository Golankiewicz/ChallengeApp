using ChallengeApp;

Console.WriteLine("Witamy w programie oceny pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();


var employee = new EmployeeInFile("Paweł", "Golankiewicz");
employee.AddGrade(12.5f);
employee.AddGrade(25);
employee.AddGrade('b');



var statistics = employee.GetStatistics();
Console.Write(employee.Name +" ");
Console.Write(employee.Surname +" ");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");






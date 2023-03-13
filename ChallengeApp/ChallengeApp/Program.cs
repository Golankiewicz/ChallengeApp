using ChallengeApp;

Console.WriteLine("Witamy w programie oceny pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();


var employee = new EmployeeInMemory("Paweł", "Golankiewicz");
employee.GradeAdded += EmployeeGradeAdded;//subskrybcja eventu

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę w Memory");
}


employee.AddGrade(12.5f);
employee.AddGrade('b');
employee.AddGrade(33);
employee.AddGrade("55");


var statistics = employee.GetStatistics();
Console.Write(employee.Name +" ");
Console.Write(employee.Surname +" ");
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");







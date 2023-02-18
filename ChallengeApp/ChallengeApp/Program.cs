using ChallengeApp;

Console.WriteLine("Witamy w programie oceny pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee("Janek", "Kowalski");
while (true)
{
    Console.WriteLine("Podaj ocenę: ");
    var input = Console.ReadLine();
  
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


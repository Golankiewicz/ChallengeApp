using ChallengeApp;

Console.WriteLine("Witamy w programie oceny pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee("Janek", "Kowalski", "specialist");

while (true)
{
    Console.WriteLine("Podaj ocenę: ");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


var statistics = employee.GetStatistics();
Console.Write(employee.Name +" ");
Console.Write(employee.Surname +" ");
Console.WriteLine(employee.Position);
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


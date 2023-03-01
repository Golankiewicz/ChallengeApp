using ChallengeApp;

Console.WriteLine("Witamy w programie oceny pracowników XYZ");
Console.WriteLine("========================================");
Console.WriteLine();

//var employee = new Employee("Janek", "Kowalski", "specialist");
var supervisor = new Supervisor("Janek", "Kowalski", "manager");

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
        //employee.AddGrade(input);
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


var statistics = supervisor.GetStatistics();
Console.Write(supervisor.Name +" ");
Console.Write(supervisor.Surname +" ");
Console.WriteLine(supervisor.Position);
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");


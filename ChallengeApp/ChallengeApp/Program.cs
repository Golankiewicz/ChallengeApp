using ChallengeApp;

var employee = new Employee("Paweł", "Golankiewicz");
employee.AddGrade("10,5");//string
employee.AddGrade(11.5f);//float
employee.AddGrade(11);//int
employee.AddGrade(21.85d);//double
employee.AddGrade(53l);//long
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Max: { statistics.Max}");
Console.WriteLine($"Min: { statistics.Min}");
Console.WriteLine($"Average: { statistics.Average:N2}");
Console.WriteLine();
Console.WriteLine($"MaxStat1: {statistics1.Max}");
Console.WriteLine($"MinStat1: {statistics1.Min}");
Console.WriteLine($"AverageStat1: {statistics1.Average:N2}");
Console.WriteLine();
Console.WriteLine($"MaxStat2: {statistics2.Max}");
Console.WriteLine($"MinStat2: {statistics2.Min}");
Console.WriteLine($"AverageStat2: {statistics2.Average:N2}");
Console.WriteLine();
Console.WriteLine($"MaxStat3: {statistics3.Max}");
Console.WriteLine($"MinStat3: {statistics3.Min}");
Console.WriteLine($"AverageStat3: {statistics3.Average:N2}");
Console.WriteLine();
Console.WriteLine($"MaxStat4: {statistics4.Max}");
Console.WriteLine($"MinStat4: {statistics4.Min}");
Console.WriteLine($"AverageStat4: {statistics4.Average:N2}");

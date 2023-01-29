using ChallengeApp;

Employee stefan = new Employee("Stefan", "Batory", 41);
Employee jan = new Employee("Jan", "Sobieski", 55);
Employee zygmunt = new Employee("Zygmunt", "Waza", 32);

stefan.AddPoints(3);
stefan.AddPoints(6);
stefan.AddPoints(4);
stefan.AddPoints(5);
stefan.AddPoints(6);

jan.AddPoints(5);
jan.AddPoints(1);
jan.AddPoints(1);
jan.AddPoints(3);
jan.AddPoints(4);

zygmunt.AddPoints(2);
zygmunt.AddPoints(3);
zygmunt.AddPoints(1);
zygmunt.AddPoints(8);
zygmunt.AddPoints(1);

List<Employee> employees = new List<Employee>()
{ stefan,jan, zygmunt };

int maxPoints = -1;
Employee bestEmployee = null;

foreach (var employee in employees)
{

    if (employee.Points > maxPoints)
    {
        maxPoints = employee.Points;
        bestEmployee = employee;
    }

}
Console.WriteLine($"The best employee is: {bestEmployee.Name} {bestEmployee.Surname}" +
    $" with {bestEmployee.Points} points");







Employee stefan = new Employee("Stefan", "Batory", 41);
Employee jan = new Employee("Jan", "Sobieski", 55);
Employee zygmunt = new Employee("Zygmunt", "Waza", 32);

stefan.AddPoints(3);
stefan.AddPoints(6);
stefan.AddPoints(4);
stefan.AddPoints(5);
stefan.AddPoints(6);

jan.AddPoints(5);
jan.AddPoints(9);
jan.AddPoints(9);
jan.AddPoints(3);
jan.AddPoints(4);

zygmunt.AddPoints(2);
zygmunt.AddPoints(3);
zygmunt.AddPoints(7);
zygmunt.AddPoints(8);
zygmunt.AddPoints(9);

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






class Employee
{
    private List<int> points = new List<int>();
    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }
    public int Points
    {
        get
        {
            return this.points.Sum();
        }
    }



    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }

    public void AddPoints(int point)
    {
        points.Add(point);
    }


}


namespace ChallengeApp
{
    public class Employee
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
}

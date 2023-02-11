
namespace ChallengeApp
{
    public class Employee
    {
        private List<float>grades= new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)//podstawowa metoda dla grade w postaci float
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"{grade} is an invalid grade");
            }
        }

        public void AddGrade(string grade) //metoda dla grade w postaci string
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine($"{grade} this string cannot be converted to float");
            }
           
        }

        public void AddGrade(int grade) //metoda dla grade w postaci int
        {
            var intGradeToFloat = (float)grade;
            this.AddGrade(intGradeToFloat);
        }

        public void AddGrade(double grade)//metoda dla grade w postaci double
        {
            var doubleGradeToFloat = (float)grade;
            this.AddGrade(doubleGradeToFloat);
        }

        public void AddGrade(long grade)//metoda dla grade w postaci long
        {
            var longGradeToFloat = (float)grade;
            this.AddGrade(longGradeToFloat);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}

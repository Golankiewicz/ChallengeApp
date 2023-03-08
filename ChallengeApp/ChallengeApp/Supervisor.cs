
namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();
        public Supervisor(string name, string surname, string position)

        {
            this.Name = name;

            this.Surname = surname;

            this.Position = position;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Position { get; private set; }

        string IEmployee.Name => throw new NotImplementedException();

        string IEmployee.Surname => throw new NotImplementedException();

        public void AddGrade(float grade)//podstawowa metoda dla grade w postaci float
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {

                throw new Exception("invalid grade value");
            }
        }



        public void AddGrade(string grade)//metoda dla grade w postaci stringa liczbowego
        {

            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "6-":
                case "-6":
                    this.grades.Add(95);
                    break;
                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-":
                case "-5":
                    this.grades.Add(75);
                    break;
                case "4+":
                case "+4":
                    this.grades.Add(65);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "4-":
                case "-4":
                    this.grades.Add(55);
                    break;
                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3-":
                case "-3":
                    this.grades.Add(35);
                    break;
                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2-":
                case "-2":
                    this.grades.Add(15);
                    break;
                case "1+":
                case "+1":
                    this.grades.Add(5);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
               

                default:

                    throw new Exception("Wrong grade - should be 1 till 6 ; press q to quit");

            }
        }

        public void AddGrade(char grade)//metoda dla grade w postaci literowej
        {

            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:

                    throw new Exception("Wrong letter");

            }
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;


            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }

        void IEmployee.AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        void IEmployee.AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        Statistics IEmployee.GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}

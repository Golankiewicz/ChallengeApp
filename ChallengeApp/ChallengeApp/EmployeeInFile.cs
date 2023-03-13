
namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname) : base(name, surname)
        {
        }
        private const string fileName = "grades.txt";
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wrong grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {

                throw new Exception("This string definitely cannot be converted to float");
            }
        }

        /*

         public override void AddGrade(int grade)
         {
             if (grade >= 0 && grade <= 100)
             {
                 using (var writer = File.AppendText(fileName))
                 {
                     writer.WriteLine(grade);
                 }

                 if (GradeAdded != null)
                 {
                     GradeAdded(this, new EventArgs());
                 }
             }
             else
             {

                 throw new Exception("invalid grade value");
             }
         }
        */

        public override void AddGrade(int grade)
        {
           var floatFromInt = (float)grade;
            AddGrade(floatFromInt);
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':

                    AddGrade(100);
                    break;

                case 'B':
                case 'b':

                    AddGrade(80);
                    break;

                case 'C':
                case 'c':

                    AddGrade(60);
                    break;

                case 'D':
                case 'd':

                    AddGrade(40);
                    break;

                case 'E':
                case 'e':

                    AddGrade(20);
                    break;
                default:

                    throw new Exception("Wrong letter");

            }
        }
       
        public override Statistics GetStatistics()

        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;


            if (File.Exists(fileName)) //odczyt z pliku i dodanie oceny do listy grades
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                    var number = float.Parse(line);
                        this.grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }


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
    }
}

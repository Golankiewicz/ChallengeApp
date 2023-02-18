namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnAverageLetterA()

        {

            //arrange

            var employee = new Employee("Paweł", "Golankiewicz");

            //act
            employee.AddGrade(96);
            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual('A', statistics.AverageLetter);

        }

       

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnAverageLetterE()

        {

            //arrange

            var employee = new Employee("Paweł", "Golankiewicz");

            //act
            employee.AddGrade(15);
            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual('E', statistics.AverageLetter);


        }
        [Test]

        public void WhenLetterGradesAdded_ShouldReturnProperAverage()

        {

            //arrange

            var employee = new Employee("Paweł", "Golankiewicz");

            //act
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('E');
            
            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(60, statistics.Average);


        }
    }
}

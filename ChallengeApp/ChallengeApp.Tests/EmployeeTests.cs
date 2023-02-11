namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnMinValue()
        {

            //arrange

            var employee = new Employee("Paweł","Golankiewicz");
            employee.AddGrade(14.75f);
            employee.AddGrade(10.0f);
            employee.AddGrade(5.25f);

            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(5.25, statistics.Min);
           
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnMaxValue()
        {

            //arrange

            var employee = new Employee("Paweł", "Golankiewicz");
            employee.AddGrade(14.75f);
            employee.AddGrade(10.0f);
            employee.AddGrade(5.25f);

            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(14.75f, statistics.Max);
        
        }

        [Test]

        public void WhenGetStatisticsCalled_ShouldReturnAverageValue()
        {

            //arrange

            var employee = new Employee("Paweł", "Golankiewicz");
            employee.AddGrade(14.75f);
            employee.AddGrade(10.0f);
            employee.AddGrade(5.25f);

            //act

            var statistics = employee.GetStatistics();

            //assert

            Assert.AreEqual(10.0f, statistics.Average);

        }
    }
}

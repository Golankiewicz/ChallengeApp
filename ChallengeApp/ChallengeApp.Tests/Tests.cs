namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]

        public void StatisticsTest()
        {

            //arrange
            var employee = new Employee("Paweł","Golankiewicz");
            employee.AddGrade(14.75f);
            employee.AddGrade(10.0f);
            employee.AddGrade(5.25f);

            var statistics = employee.GetStatistics();

            //act


            //assert
            Assert.AreEqual(statistics.Min, 5.25f);
            Assert.AreEqual(statistics.Max, 14.75f);
            Assert.AreEqual(statistics.Average, 10.0f);




        }
    }
}

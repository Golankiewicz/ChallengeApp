namespace ChallengeApp.Tests
{
    public class Tests
    {
       
        [Test]
        public void WhenAddedPoints_ShouldResult()
        {
            //arrange

            var employee = new Employee("Jan","Sobieski",33);
            employee.AddPoints(5);
            employee.AddPoints(7);
            employee.AddPoints(-12);

            //act

            var result = employee.Points;

            //assert

            Assert.AreEqual(0,employee.Points);
            
        }
    }
}
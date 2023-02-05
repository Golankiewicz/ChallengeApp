namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void WhenTwoIntNumbersAreEqualThenTestShouldBePositive()
        {
            //arrange
            int number1 = 2;
            int number2 = 2;

            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void WhenTwoFloatNumbersAreEqualThenTestShouldBePositive()
        {
            //arrange
            float number3 = 2.5f;
            float number4 = 2.5f;

            //act

            //assert
            Assert.AreEqual(number3, number4);

        }



        [Test]
        public void WhenTwoStringsAreEqualThenTestShouldBePositive()
        {
            //arrange
            string name1 = "Paweł";
            string name2 = "Paweł";

            //act

            //assert
            Assert.AreEqual(name1, name2);

        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
            var user1 = GetUser("Paweł");
            var user2 = GetUser("Paweł");

            //act

            //assert

            Assert.AreNotEqual(user1, user2);

        }
        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}

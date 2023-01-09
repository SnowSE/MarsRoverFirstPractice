using MarsRoverFirstPractice;

namespace MarsRoverTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var map = "\U0001f7e9\U0001f7e9🌳\U0001f7e9\U0001f7e9\r\n\U0001f7e9\U0001f7e9\U0001f7e9\U0001f7e9\U0001f7e9\r\n\U0001f7e9\U0001f7e9\U0001f7e9🌳\U0001f7e9\r\n\U0001f7e9🌳\U0001f7e9\U0001f7e9\U0001f7e9\r\n➡️\U0001f7e9\U0001f7e9\U0001f7e9\U0001f7e9"
            Class1.simulateRover();
            Assert.Pass();
        }
    }
}
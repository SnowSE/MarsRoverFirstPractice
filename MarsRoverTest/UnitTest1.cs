using MarsRoverFirstPractice;
using System.Drawing;

namespace MarsRoverTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void DirectionEmtpy()
        //{
        //    var map = "";
        //    var directionCommands = "";
        //    var exception = Assert.Throws<Exception>(() => MarsRover.simulateRover(map, directionCommands));
        //    Assert.That("Direction commands are empty" == exception.Message);
        //}

        [Test]
        public void RoverMoveOneForward()
        {
            var map = "➡️ 0 0 0";
            var directionCommands = "F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 1);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");
        }

        [Test]
        public void RoverMoveOneBlocked()
        {
            var map = "➡️ X 0 0";
            var directionCommands = "F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

        }

    }

}
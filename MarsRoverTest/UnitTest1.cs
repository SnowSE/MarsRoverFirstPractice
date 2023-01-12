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
        public void RoverMoveOne()
        {
            var map = "➡️ 0";
            var directionCommands = "F";
            var result = MarsRover.simulateRover(map, directionCommands);
        }
    }

}
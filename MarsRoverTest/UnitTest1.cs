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

        [Test]
        public void RoverMove()
        {
            var map = "➡️ 0 0 0";
            var directionCommands = "F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 1);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

            directionCommands = "F F";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 2);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

            directionCommands = "F B";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
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

        [Test]
        public void RoverMoveOneOutOfBounds()
        {
            var map = "⬇️ X 0 0";
            var directionCommands = "F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬇️");

            map = "⬅️ X 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬅️");
        }

        [Test]
        public void RoverRotateRight()
        {
            var map = "⬆️ 0 0 0";
            var directionCommands = "R";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

            map = "➡️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬇️");

            map = "⬇️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬅️");

            map = "⬅️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬆️");
        }

        [Test]
        public void RoverRotateLeft()
        {
            var map = "⬆️ 0 0 0";
            var directionCommands = "L";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬅️");

            map = "➡️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬆️");

            map = "⬇️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

            map = "⬅️ 0 0 0";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "⬇️");
        }

        [Test]
        public void RoverMoveAndRoate()
        {
            var map = "⬆️ 0 0 0";
            var directionCommands = "R F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 1);
            Assert.That(result.Item1.Y == 0);
            Assert.That(result.Item2 == "➡️");

            map = "➡️ 0 0 0";
            directionCommands = "L F";
            result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 0);
            Assert.That(result.Item1.Y == 1);
            Assert.That(result.Item2 == "⬆️");            
        }

        [Test]
        public void RoverBigMapMoveAndRotate()
        {
            // 0 X 0 0
            // 0 0 0 0
            // X 0 X 0
            // ⬆️ 0 0 0            
            var map = "⬆️ 0 0 0 X 0 X 0 0 0 0 0 0 X 0 0";
            var directionCommands = "R F F F L F F F L F";
            var result = MarsRover.simulateRover(map, directionCommands);
            Assert.That(result.Item1.X == 2);
            Assert.That(result.Item1.Y == 3);
            Assert.That(result.Item2 == "⬅️");
        }
    }

}
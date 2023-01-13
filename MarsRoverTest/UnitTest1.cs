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
        public void navigateAcrossMap()
        {
            //var map = "🟩🟩🌳🟩🟩🟩🟩🟩🟩🟩🟩🟩🟩🌳🟩🟩🌳🟩🟩🟩➡️🟩🟩🟩🟩";
            var map = "OOXOOOOOOOOOOXOOXOOOEOOOO";
            var moveCommands = "FFLFFFRFFLF";
            var result = Class1.simulateRover(map, moveCommands);

            var expectedDestination = new Point(0, 4);
            var expectedDirection = 'N';
            Assert.That(expectedDestination.X, Is.EqualTo(result.Item1.X));
            Assert.That(expectedDestination.Y, Is.EqualTo(result.Item1.Y));
            Assert.That(expectedDirection, Is.EqualTo(result.Item2));
        }

        [Test]
        public void ranIntoWall()
        {
            var map = "OOXOOOOOOOOOOXOOXOOOEOOOO";
            var moveCommands = "LLFFFFFFFFFF";
            var result = Class1.simulateRover(map, moveCommands);
            var expectedDestination = new Point(4, 0);
            var expectedDirection = 'W';
            Assert.That(expectedDestination.X, Is.EqualTo(result.Item1.X));
            Assert.That(expectedDestination.Y, Is.EqualTo(result.Item1.Y));
            Assert.That(expectedDirection, Is.EqualTo(result.Item2));
        }

        [Test]
        public void ranIntoObstacle()
        {
            var map = "OOXOOOOOOOOOOXOOXOOOEOOOO";
            var moveCommands = "FFFLFFFF";
            var result = Class1.simulateRover(map, moveCommands);
            var expectedDestination = new Point(3, 3);
            var expectedDirection = 'N';
            Assert.That(expectedDestination.X, Is.EqualTo(result.Item1.X));
            Assert.That(expectedDestination.Y, Is.EqualTo(result.Item1.Y));
            Assert.That(expectedDirection, Is.EqualTo(result.Item2));
        }
        [Test]
        public void ranIntoObstacleAndWall()
        {
            var map = "OOXOOOOOOOOOOXOOXOOOEOOOO";
            var moveCommands = "FLFFRFFRFFLLFFRF";
            var result = Class1.simulateRover(map, moveCommands);
            var expectedDestination = new Point(3, 4);
            var expectedDirection = 'E';
            Assert.That(expectedDestination.X, Is.EqualTo(result.Item1.X));
            Assert.That(expectedDestination.Y, Is.EqualTo(result.Item1.Y));
            Assert.That(expectedDirection, Is.EqualTo(result.Item2));
        }
    }
}
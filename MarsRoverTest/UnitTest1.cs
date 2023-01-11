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
        public void RotateLeft()
        {
            MarsRover rover = new MarsRover("0 0 W");
            rover.RotateLeft();
            Assert.AreEqual("S", rover.direction);
        }
        [Test]
        public void RotateRight()
        {
            MarsRover rover = new MarsRover("0 0 W");
            rover.RotateRight();
            Assert.AreEqual("N", rover.direction);
        }
        [Test]
        public void MoveForward()
        {
            MarsRover rover = new MarsRover("1 2 N");
            rover.MoveForward();
            Assert.AreEqual(3, rover.y);
        }
        [Test]
        public void RoverShouldMove()
        {
            MarsRover rover = new MarsRover("1 2 N");
            rover.Move("LFLFLFLFF");
            Assert.AreEqual("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
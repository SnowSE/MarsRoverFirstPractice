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
        public void positionEastTurningleftShouldBeNorth()
        {
            var map = new char[,] {
                { '.', '.', '#', '.', '.' },
                { '.', '.', '.', '.', '.' },
                { '.', '.', '.', '#', '.' },
                { '.', '#', '.', '.', '.' },
                { '>', '.', '.', '.', '.' }};
            
            var rover = new Class1(0, 4, 'E', map);
            rover.simulateRover('L');
            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(4, rover.Y);
            Assert.AreEqual('N', rover.Direction);
            //Class1.simulateRover(map, directions );
        }
        [Test]
        public void TestWhenTurningToObstacle()
        {
            var map = new char[,] {
                { '.', '.', '#', '.', '.' },
                { '.', '.', '.', '.', '.' },
                { '.', '.', '.', '#', '.' },
                { '.', '#', '.', '.', '.' },
                { '>', '.', '.', '.', '.' }};

            var rover = new Class1(0, 4, 'S', map);
            rover.simulateRover('U');
            Assert.AreEqual(0, rover.X);
            Assert.AreEqual(4, rover.Y);
            Assert.AreEqual('S', rover.Direction);
            //Class1.simulateRover(map, directions );
        }





    }


}
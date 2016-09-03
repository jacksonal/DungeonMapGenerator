using NUnit.Framework;

namespace DungeonMapGenerator.Tests
{
    [TestFixture]
    public class MapBuilderTests
    {
        private MapBuilder _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new MapBuilder();
        }

        [Test]
        public void GetRandomCoords_GivenMaxValues_ReturnedCoordsWithinRange()
        {
	        var coord = _systemUnderTest.GetRandomLocation(10, 10);
			Assert.LessOrEqual(coord.XCoord,10);
			Assert.LessOrEqual(coord.YCoord, 10);

			Assert.GreaterOrEqual(coord.XCoord,0);
			Assert.GreaterOrEqual(coord.YCoord, 0);
		}
    }
}
using NUnit.Framework;

namespace DungeonMapDrawer.Tests
{
    [TestFixture]
    public class MapDrawerTests
    {
        private MapDrawer _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new MapDrawer();
        }

        [Test]
        public void GivenDimensionsAndTilePixelSize_MapSizeCorrect()
        {
            _systemUnderTest.SetTileSize(10);
            _systemUnderTest.SetMapTileDimensions(10, 10);

            Assert.AreEqual(100, _systemUnderTest.PixelHeight);
            Assert.AreEqual(100, _systemUnderTest.PixelWidth);
        }
    }
}

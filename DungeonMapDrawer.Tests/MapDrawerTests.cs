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
            SetMapSize(10,10);

            Assert.AreEqual(100, _systemUnderTest.PixelHeight);
            Assert.AreEqual(100, _systemUnderTest.PixelWidth);
        }

        [Test]
        public void DrawMap_GivenDimensionsAndTilePixelSize_ImageCreated()
        {
            SetMapSize(10,10);

            Assert.IsNotNull(_systemUnderTest.DrawMap());
        }

        [Test]
        public void DrawMap_GivenDimensionsAndTilePixelSize_ImageSizeCorrect()
        {
            SetMapSize(10, 10);

            var image = _systemUnderTest.DrawMap();
            Assert.AreEqual(100, image.Size.Height);
            Assert.AreEqual(100, image.Size.Width);
        }

        private void SetMapSize(int tilePixels, int mapTiles)
        {
            _systemUnderTest.SetTileSize(tilePixels);
            _systemUnderTest.SetMapTileDimensions(mapTiles);
        }
    }
}

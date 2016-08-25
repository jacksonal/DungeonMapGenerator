using System.Drawing;
using System.Globalization;
using DungeonMapGenerator.Model;
using Moq;
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

        [Test]
        public void DrawMap_PixelFillerIsBlack()
        {
            SetMapSize(10, 10);

            var image = _systemUnderTest.DrawMap();
            Assert.AreEqual(Color.Black.ToArgb(),image.GetPixel(0,0).ToArgb());
        }

        [Test]
        public void DrawMap_WithMapAsArg_PixelFillerIsBlack()
        {
            Mock<IMap> map = new Mock<IMap>();
            map.Setup(m => m.TileHeight).Returns(10);
            map.Setup(m => m.TileWidth).Returns(10);
            var image = _systemUnderTest.DrawMap(map.Object);
            Assert.AreEqual(Color.Black.ToArgb(), image.GetPixel(0, 0).ToArgb());
        }
        private void SetMapSize(int tilePixels, int mapTiles)
        {
            _systemUnderTest.SetTileSize(tilePixels);
            _systemUnderTest.SetMapTileDimensions(mapTiles);
        }
    }
}

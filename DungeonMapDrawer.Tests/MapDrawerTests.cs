using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
            var map = GetMockMap();

            var image = _systemUnderTest.DrawMap(map.Object);

            Assert.AreEqual(100, image.Height);
            Assert.AreEqual(100, image.Width);
        }

        [Test]
        public void DrawMap_GivenDimensionsAndTilePixelSize_ImageCreated()
        {
            var map = GetMockMap();

            Assert.IsNotNull(_systemUnderTest.DrawMap(map.Object));
        }

        [Test]
        public void DrawMap_GivenDimensionsAndTilePixelSize_ImageSizeCorrect()
        {
            var map = GetMockMap();

            var image = _systemUnderTest.DrawMap(map.Object);
            Assert.AreEqual(100, image.Size.Height);
            Assert.AreEqual(100, image.Size.Width);
        }

        [Test]
        public void DrawMap_PixelFillerIsBlack()
        {
            var map = GetMockMap();

            var image = _systemUnderTest.DrawMap(map.Object);
            Assert.AreEqual(Color.Black.ToArgb(),image.GetPixel(0,0).ToArgb());
        }

        [Test]
        public void DrawMap_WithMapAsArg_PixelFillerIsBlack()
        {
            var map = GetMockMap();
            var image = _systemUnderTest.DrawMap(map.Object);
            Assert.AreEqual(Color.Black.ToArgb(), image.GetPixel(0, 0).ToArgb());
        }

        [Test,Ignore]
        public void DrawMap_MapHasRoom_RoomMarkedWhite()
        {
            var map = GetMockMap();
            var image = _systemUnderTest.DrawMap(map.Object);
            var roomPixel = image.GetPixel(image.Height - (10*map.Object.Rooms.First().YCoord),
                image.Width - (10*map.Object.Rooms.First().XCoord));
            Assert.AreEqual(Color.White.ToArgb(),roomPixel.ToArgb());
        }

        private Mock<IMap> GetMockMap()
        {
            Mock<IMap> map = new Mock<IMap>();
            map.Setup(m => m.TileHeight).Returns(10);
            map.Setup(m => m.TileWidth).Returns(10);
            map.Setup(m => m.Rooms).Returns(new List<Room>
            {
                new Room {Height = 4, Width = 4, XCoord = 3, YCoord = 3}
            });
            return map;
        }
    }
}

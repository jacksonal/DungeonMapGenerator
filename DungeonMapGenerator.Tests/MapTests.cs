using DungeonMapGenerator.Model;
using NUnit.Framework;

namespace DungeonMapGenerator.Tests
{
    [TestFixture]
    public class MapTests
    {
        private Map _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new Map();
        }

        [Test]
        public void MapHeightAndWidth_TileDimensions_ReturnInteger()
        {
            _systemUnderTest.Size = MapSize.Medium;

            Assert.Greater(_systemUnderTest.TileHeight,0);
            Assert.Greater(_systemUnderTest.TileWidth, 0);
        }

        [Test]
        public void AddRoom_RoomInCollection()
        {
            _systemUnderTest.AddRoom(new Room());
            Assert.IsNotEmpty(_systemUnderTest.Rooms);
        }
    }
}

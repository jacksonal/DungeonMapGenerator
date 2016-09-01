using System.Configuration;
using DungeonMapGenerator.Model;
using NUnit.Framework;

namespace DungeonMapGenerator.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        private MapValidator _systemUnderTest;

        [SetUp]
        public void BeforeEach()
        {
            _systemUnderTest = new MapValidator();
        }

        [Test]
        public void IsRoomValid_EmptyRoomList_RoomIsValid()
        {
            Assert.IsTrue(_systemUnderTest.IsRoomValid(new Map(), new Room()));
        }

        [Test]
        public void IsRoomValid_NoCollidingRooms_RoomIsValid()
        {
            var map = new Map();
            map.AddRoom(new Room {Height = 4,Width = 4,XCoord = 0,YCoord = 0});
            Assert.IsTrue(_systemUnderTest.IsRoomValid(map,new Room {Height = 4, Width = 4, XCoord = 5,YCoord = 1}));
        }

        [Test]
        public void IsRoomValid_RoomsCollide_RoomIsNotValid()
        {
            var map = new Map();
            map.AddRoom(new Room { Height = 4, Width = 4, XCoord = 0, YCoord = 0 });
            Assert.IsFalse(_systemUnderTest.IsRoomValid(map, new Room { Height = 4, Width = 4, XCoord = 1, YCoord = 1 }));
        }

        [Test]
        public void IsRoomValid_RoomOutsideMapBounds_RoomIsNotValid()
        {
            var map = new Map {Size = MapSize.Small};
            Assert.IsFalse(_systemUnderTest.IsRoomValid(map, new Room { Height = 4, Width = 4, XCoord = -1, YCoord = -1 }));
        }
        [Test]
        public void IsRoomValid_RoomInsideMapBounds_RoomIsValid()
        {
            var map = new Map { Size = MapSize.Small };
            Assert.IsTrue(_systemUnderTest.IsRoomValid(map, new Room { Height = 4, Width = 4, XCoord = 1, YCoord = 1 }));
        }
    }
}
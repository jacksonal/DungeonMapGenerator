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

	    [Test]
	    public void GetRandomRoomSize_GivenMaxValues_ReturnsDimensionsWithinRange()
	    {
			var coord = _systemUnderTest.GetRandomRoomSize(10, 10);
			Assert.LessOrEqual(coord.Width, 10);
			Assert.LessOrEqual(coord.Height, 10);

			Assert.GreaterOrEqual(coord.Width, 0);
			Assert.GreaterOrEqual(coord.Height, 0);
		}

		/// <summary>
		/// a room should meet certain criteria.
		/// ---
		/// |_|		This is a one square room its dimensions are 3x3. we shouldn't generate rooms this small
		/// ---
		/// ----
		/// |__|	This is not a room. it is a hallway. the dimensions are 4x3. we shouldn't generate rooms that have a functional width of 1.
		/// ----
		/// ----
		/// |__|	This IS a room.
		/// |__|
		/// ----
		/// 
		/// A room has a height and width of at least 4.
		/// </summary>
		[Test]
		public void GetRandomRoomSize_ReturnsDimensionsWithinOfAppropriateSize()
		{
			var coord = _systemUnderTest.GetRandomRoomSize(10, 10);
			Assert.LessOrEqual(coord.Width, 10);
			Assert.LessOrEqual(coord.Height, 10);

			Assert.GreaterOrEqual(coord.Width, 4);
			Assert.GreaterOrEqual(coord.Height, 4);
		}
	}
}
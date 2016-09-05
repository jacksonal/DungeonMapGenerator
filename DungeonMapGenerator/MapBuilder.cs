using System;

namespace DungeonMapGenerator
{
    public class MapBuilder
    {
	    private int DEFAULT_SEED = 12345;
	    private int MINIMUM_ROOM_SIZE = 4;
	    private Random _random;

	    public MapBuilder()
	    {
		    _random = new Random(DEFAULT_SEED);

	    }

	    public MapBuilder(int seed)
	    {
			_random = new Random(seed);
		}

	    public MapCoordinate GetRandomLocation(int maxWidth, int maxHeight)
	    {
		    return new MapCoordinate(_random.Next(0, maxWidth),_random.Next(0, maxHeight));
	    }

	    public RoomSize GetRandomRoomSize(int maxWidth, int maxHeight)
	    {
			return new RoomSize(_random.Next(MINIMUM_ROOM_SIZE, maxWidth), _random.Next(MINIMUM_ROOM_SIZE, maxHeight));
		}
    }

	public class RoomSize
	{
		public int Width { get; }
		public int Height { get; }

		public RoomSize(int width, int height)
		{
			Width = width;
			Height = height;
		}
	}

	public class MapCoordinate
	{
		public int XCoord { get; }
		public int YCoord { get; }

		public MapCoordinate(int xCoord, int yCoord)
		{
			XCoord = xCoord;
			YCoord = yCoord;
		}
	}
}
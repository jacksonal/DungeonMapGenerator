using System;

namespace DungeonMapGenerator
{
    public class MapBuilder
    {
	    private int DEFAULT_SEED = 12345;
	    private Random _random;

	    public MapBuilder()
	    {
		    _random = new Random(DEFAULT_SEED);

	    }

	    public MapBuilder(int seed)
	    {
			_random = new Random(seed);
		}

	    public MapCoordinate GetRandomLocation(int width, int height)
	    {
		    return new MapCoordinate(_random.Next(0,width),_random.Next(0,height));
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
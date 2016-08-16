using System.Collections.Generic;

namespace DungeonMapGenerator.Model
{
    public interface IMap
    {
        int TileHeight { get; }
        int TileWidth { get; }
        MapSize Size { get; }
        IEnumerable<IRoom> Rooms { get; }
        
    }

    public class Map : IMap
    {
        public int TileHeight { get { return GetMapHeight(); } }

        public int TileWidth { get { return GetMapWidth(); } }

        public MapSize Size { get; }
        public IEnumerable<IRoom> Rooms { get; }

        private int GetMapWidth()
        {
            throw new System.NotImplementedException();
        }

        private int GetMapHeight()
        {
            throw new System.NotImplementedException();
        }
    }

}
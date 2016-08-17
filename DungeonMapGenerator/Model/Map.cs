using System;
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

        public MapSize Size { get; set; }
        public IEnumerable<IRoom> Rooms { get; }

        public Map()
        {
            Rooms = new List<IRoom>();
        }

        private int GetMapWidth()
        {
            return SizeToInt();
        }

        private int GetMapHeight()
        {
            return SizeToInt();
        }

        private int SizeToInt()
        {
            switch (Size)
            {
                case MapSize.Small:
                    return 10;
                case MapSize.Medium:
                    return 20;
                case MapSize.Large:
                    return 40;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
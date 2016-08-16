using System.Collections.Generic;

namespace DungeonMapGenerator.Model
{
    public interface IRoom
    {
        int XCoord { get; set; }
        int YCoord { get; set; }
        int Width { get; set; }
    }

    public class Room : IRoom
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Width { get; set; }
    }
}
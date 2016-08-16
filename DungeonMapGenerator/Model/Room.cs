using System.Collections.Generic;

namespace DungeonMapGenerator.Model
{
    public interface IRoom
    {
        /// <summary>
        /// Top left coordinate
        /// </summary>
        int XCoord { get; set; }
        /// <summary>
        /// Top left coordinate
        /// </summary>
        int YCoord { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }

    public class Room : IRoom
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
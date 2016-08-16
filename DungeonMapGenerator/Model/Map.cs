using System.Collections.Generic;

namespace DungeonMapGenerator.Model
{
    public interface IMap
    {
        MapSize Size { get; }
        IEnumerable<IRoom> Rooms { get; }
    }
}
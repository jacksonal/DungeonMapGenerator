using System.Linq;
using DungeonMapGenerator.Model;

namespace DungeonMapGenerator
{
    public class MapValidator
    {
        public bool IsRoomValid(IMap map, IRoom toAdd)
        {
            var ret = MapContainsRoom(map, toAdd); ;
            if (map.Rooms.Any() && ret)
            {
                ret = !map.Rooms.Any(r => DoRoomsCollide(r, toAdd));
            }
            return ret;
        }

        private bool MapContainsRoom(IMap map, IRoom room)
        {
            return (room.XCoord >= 0) &&
                   (room.YCoord >= 0) &&
                   (room.XCoord + room.Width <= map.TileWidth) &&
                   (room.YCoord + room.Height <= map.TileHeight);
        }

        private bool DoRoomsCollide(IRoom room1, IRoom room2)
        {
            return room1.XCoord < room2.XCoord + room2.Width &&
                   room1.XCoord + room1.Width > room2.XCoord &&
                   room1.YCoord < room2.YCoord + room2.Height &&
                   room1.Height + room1.YCoord > room2.YCoord;
        }
    }
}
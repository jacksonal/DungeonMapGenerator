using DungeonMapDrawer;
using DungeonMapGenerator.Model;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawer = new MapDrawer();
            var room = new Room {Height = 4, Width = 4, XCoord = 10, YCoord = 10};
            var map = new Map {Size = MapSize.Large};
            map.AddRoom(room);
            var mapImage = drawer.DrawMap(map);
            mapImage.Save("map.png");
        }
    }
}

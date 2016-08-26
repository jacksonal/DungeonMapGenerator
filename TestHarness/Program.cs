using DungeonMapDrawer;
using DungeonMapGenerator.Model;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawer = new MapDrawer();
            var map = new Map {Size = MapSize.Large};
            var mapImage = drawer.DrawMap(map);
            mapImage.Save("map.png");
        }
    }
}

using DungeonMapDrawer;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawer = new MapDrawer();
            drawer.SetTileSize(50);
            drawer.SetMapTileDimensions(20);
            var mapImage = drawer.DrawMap();
            mapImage.Save("map.png");
        }
    }
}

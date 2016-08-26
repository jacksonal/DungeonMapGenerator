using System.Drawing;
using DungeonMapGenerator.Model;

namespace DungeonMapDrawer
{
    public class MapDrawer
    {
        private const int TILE_SIZE = 10;
        protected Bitmap DrawFoundation(int width, int height)
        {
            var ret = new Bitmap(width,height);
            using (var mapGraphics = Graphics.FromImage(ret))
            {
                mapGraphics.FillRectangle(Brushes.Black,0,0,width,height);
                mapGraphics.Flush();
            }
            return ret;
        }

        public Bitmap DrawMap(IMap map)
        {
            var image = DrawFoundation(map.TileWidth* TILE_SIZE, map.TileWidth* TILE_SIZE);
            image = DrawRooms(map, image);
            return image;
        }

        private Bitmap DrawRooms(IMap map, Bitmap image)
        {
            using (var mapGraphics = Graphics.FromImage(image))
            {
                foreach (var room in map.Rooms)
                {
                    var width = room.Width*TILE_SIZE;
                    var height = room.Height*TILE_SIZE;
                    var xcoord = room.XCoord*TILE_SIZE;
                    var ycoord = room.YCoord*TILE_SIZE;
                    mapGraphics.FillRectangle(Brushes.White, xcoord, ycoord, width, height);
                }
                mapGraphics.Flush();
            }
            return image;
        }
    }
}

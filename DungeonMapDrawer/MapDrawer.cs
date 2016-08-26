using System.Drawing;
using DungeonMapGenerator.Model;

namespace DungeonMapDrawer
{
    public class MapDrawer
    {
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
            return DrawFoundation(map.TileWidth*10,map.TileWidth*10);
        }
    }
}

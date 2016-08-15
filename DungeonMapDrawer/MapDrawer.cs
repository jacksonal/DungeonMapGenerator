namespace DungeonMapDrawer
{
    public class MapDrawer
    {
        private int _tilePixelHeight;
        private int _tilePixelWidth;
        private int _mapTileHeight;
        private int _mapTileWidth;

        public int PixelHeight { get {return _tilePixelHeight * _mapTileHeight;} }
        public int PixelWidth { get {return _tilePixelWidth * _mapTileWidth;} }
        public void SetTileSize(int height, int width = 0)
        {
            _tilePixelHeight = height;
            _tilePixelWidth = width > 0 ? width : height;
        }

        public void SetMapTileDimensions(int height, int width = 0)
        {
            _mapTileHeight = height;
            _mapTileWidth = width > 0 ? width : height;
        }

        
    }
}

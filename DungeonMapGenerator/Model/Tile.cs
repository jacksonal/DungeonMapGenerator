namespace DungeonMapGenerator.Model
{
    public interface ITile
    {
        
    }
    public abstract class Tile : ITile
    {
         
    }

    public class WallTile : Tile
    {
        WallDirection Direction { get; set; }
    }

    public class FloorTile : Tile
    {
    }

    public class EarthTile : Tile
    {
    }
}
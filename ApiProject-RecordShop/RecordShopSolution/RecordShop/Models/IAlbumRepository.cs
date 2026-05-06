
namespace RecordShop.Models
{
    public interface IAlbumRepository 
    {
        List<Album> FindAlbumInStock();
        Album FindAlbumById(int id);
    }
}

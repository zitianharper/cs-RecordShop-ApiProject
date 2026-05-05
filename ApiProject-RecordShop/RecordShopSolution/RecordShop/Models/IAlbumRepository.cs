
namespace RecordShop.Models
{
    public interface IAlbumRepository 
    {
        List<Album> FindAlbumInStock();
    }
}

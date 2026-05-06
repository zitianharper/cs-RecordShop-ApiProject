
namespace RecordShop.Models
{
    public interface IAlbumRepository 
    {
        List<Album> FindAlbumInStock();
        Album FindAlbumById(int id);
        Album MakeAlbum(Album album);
        Album OverwriteAlbum(int id, Album updated);
    }
}

using System.Text.Json;

namespace RecordShop.Models
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly string _filePath = Path.Combine("Data", "Albums.json");
        private readonly List<Album> _album;

        public AlbumRepository()
        {
            var json = File.ReadAllText(_filePath);
            _album = JsonSerializer.Deserialize<List<Album>>(json) ?? new List<Album>();
        }

        public List<Album> FindAllAlbum()
        {
            return _album ?? new List<Album>();
        }
    }
}

using System.Text.Json;
using Microsoft.Extensions.Configuration;


namespace RecordShop.Models
{
    public class AlbumRepository : IAlbumRepository
    {
        //private readonly string _filePath = Path.Combine("Data", "Albums.json");
        private readonly string _filePath;
        private readonly List<Album> _album;

        public AlbumRepository(IConfiguration config)
        {
            _filePath = config["FileSettings:AlbumFilePath"]; //this connects to appsettings.Development 

            var json = File.ReadAllText(_filePath);
            _album = JsonSerializer.Deserialize<List<Album>>(json) ?? new List<Album>();
        }
        
        public List<Album> FindAlbumInStock()
        {
            return _album ?? new List<Album>();
        }
    }
}

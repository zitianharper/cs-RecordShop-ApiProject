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

        //GET all albums in stock
        
        public List<Album> FindAlbumInStock()
        {
            return _album ?? new List<Album>();
        }

        //GET album by Id

        public Album FindAlbumById(int id)
        {
           
            return _album.FirstOrDefault(a => a.Id == id);
                
        }

        //POST album

        public Album MakeAlbum(Album album)
        {
            //Deserialize

            //Generate new Id
            int newId = _album.Any() ? _album.Max(a => a.Id) + 1 : 1;
            //Assign Id
            album.Id = newId;
            //Add to List
            _album.Add(album);
            //Serialize 
            var json = JsonSerializer.Serialize(_album);
            //Write
            File.WriteAllText(_filePath, json);
            return album;   
        }
    }
}

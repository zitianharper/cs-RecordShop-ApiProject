namespace RecordShop.Web.Models;

public class Album
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public int Release { get; set; }
    public string Genre { get; set; } = string.Empty;
    public int StockQuantity { get; set; }
    public decimal Price { get; set; }
}

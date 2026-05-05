namespace RecordShop.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public int Release { get; set; }
        public string Genre { get; set; }
        public int StockQuantity { get; set }
        public decimal Price { get; set; }
    }
}

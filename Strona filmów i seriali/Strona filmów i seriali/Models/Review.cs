namespace Strona_filmów_i_seriali.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int CatalogItemId { get; set; }

        public string Username { get; set; } = "";
        public int Rating { get; set; }
        public string Content { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}

namespace Strona_filmów_i_seriali.Models
{
    public record CatalogItem(
        int Id,
        string Title,
        int Year,
        string Genre,
        string Type,
        double Rating,
        string Description,
        string Duration,
        int? Seasons,
        int? Episodes,
        string[] Cast
    );
}

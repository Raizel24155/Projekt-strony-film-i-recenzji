using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Data
{
    public class ReviewData
    {
        public static List<Review> Reviews = new()
        {
            new Review
            {
                Id = 1,
                CatalogItemId = 1,
                Username = "FilmFan123",
                Rating = 10,
                Content = "Niesamowity film! Świetna historia, muzyka i efekty specjalne.",
                CreatedAt = new DateTime(2026, 10, 20)
            },

            new Review
            {
                Id = 2,
                CatalogItemId = 1,
                Username = "KinoManiak",
                Rating = 9,
                Content = "Jeden z najlepszych filmów science fiction, jakie widziałem.",
                CreatedAt = new DateTime(2026, 10, 22)
            },

            new Review
            {
                Id = 3,
                CatalogItemId = 3,
                Username = "Serialowy",
                Rating = 10,
                Content = "Świetnie napisane postacie i niesamowita przemiana głównego bohatera.",
                CreatedAt = new DateTime(2026, 10, 25)
            }
        };

        public static List<Review> GetReviews(int catalogItemId)
        {
            return Reviews
                .Where(x => x.CatalogItemId == catalogItemId)
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
        }

        public static List<Review> GetReviewsByUsername(string username)
        {
            return Reviews
                .Where(x => x.Username.Equals(
                    username,
                    StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.CreatedAt)
                .ToList();
        }

        public static void AddReview(Review review)
        {
            review.Id = Reviews.Count == 0
                ? 1
                : Reviews.Max(x => x.Id) + 1;

            Reviews.Add(review);
        }
    }
}

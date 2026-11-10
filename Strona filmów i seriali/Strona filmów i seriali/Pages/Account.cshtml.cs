using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Strona_filmów_i_seriali.Data;
using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Pages
{
    public class AccountModel : PageModel
    {
        public string Username { get; set; } = "";

        public List<UserReviewEntry> Reviews { get; set; } = new();

        public double AverageRating =>
            Reviews.Count > 0
                ? Reviews.Average(x => x.Review.Rating)
                : 0;

        public void OnGet(string username)
        {
            Username = username;

            var userReviews = ReviewData.GetReviewsByUsername(username);

            Reviews = userReviews
                .Select(review => new UserReviewEntry(
                    review,
                    CatalogData.Items.FirstOrDefault(
                        x => x.Id == review.CatalogItemId)
                ))
                .ToList();
        }
    }

    public record UserReviewEntry(
        Review Review,
        CatalogItem? Item
    );
}


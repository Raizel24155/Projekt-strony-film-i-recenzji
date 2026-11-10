using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Strona_filmów_i_seriali.Data;
using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Pages
{
    public class DetailsModel : PageModel
    {
        public CatalogItem? Item { get; set; }

        public List<Review> Reviews { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            Item = CatalogData.Items
                .FirstOrDefault(x => x.Id == id);

            if (Item == null)
            {
                return NotFound();
            }

            Reviews = ReviewData.GetReviews(id);

            return Page();
        }

        public IActionResult OnPostAddReview(
            int id,
            string username,
            int rating,
            string content)
        {
            var item = CatalogData.Items
                .FirstOrDefault(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(content) ||
                rating < 1 || rating > 10 ||
                username.Length > 30 ||
                content.Length > 1000)
            {
                return RedirectToPage("/Details", new { id });
            }

            ReviewData.AddReview(new Review
            {
                CatalogItemId = id,
                Username = username.Trim(),
                Rating = rating,
                Content = content.Trim(),
                CreatedAt = DateTime.Now
            });

            return RedirectToPage("/Details", new { id });
        }
    }
}

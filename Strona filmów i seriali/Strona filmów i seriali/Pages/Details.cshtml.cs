using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Strona_filmów_i_seriali.Data;
using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Pages
{
    public class DetailsModel : PageModel
    {
        public CatalogItem? Item { get; set; }

        public IActionResult OnGet(int id)
        {
            Item = CatalogData.Items
                .FirstOrDefault(x => x.Id == id);

            if (Item == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Strona_filmów_i_seriali.Data;
using Strona_filmów_i_seriali.Models;

namespace Strona_filmów_i_seriali.Pages
{
    public class SearchModel : PageModel
    {
        public string? Query { get; set; }
        public string? Type { get; set; }

        public List<CatalogItem> Items { get; set; } = new();

        public void OnGet(string? query, string? type)
        {
            Query = query;
            Type = type;

            Items = CatalogData.Items;

            if (!string.IsNullOrWhiteSpace(Type))
            {
                Items = Items
                    .Where(x => x.Type.Equals(
                        Type,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (!string.IsNullOrWhiteSpace(Query))
            {
                Items = Items
                    .Where(x => x.Title.Contains(
                        Query,
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }
        }
    }
}

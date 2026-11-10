using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Strona_filmów_i_seriali.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPostLogin()
        {
            return Page();
        }

        public IActionResult OnPostRegister()
        {
            return Page();
        }
    }
}

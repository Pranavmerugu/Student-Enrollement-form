using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;

namespace LiquorStore.Pages.Products
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Category { get; set; }

        public void OnGet()
        {
            // Category will be populated from the query string when provided (e.g. /Products?category=whiskey)
        }
    }
}

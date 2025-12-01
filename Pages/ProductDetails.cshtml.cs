using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages;

public class ProductDetailsModel : PageModel
{
    public ProductCategory? Category { get; private set; }
    public ProductItem? Product { get; private set; }

    public IActionResult OnGet(string category, string product)
    {
        var match = ProductCatalog.FindProduct(category, product);
        if (match is null)
        {
            return NotFound();
        }

        (Category, Product) = match.Value;
        return Page();
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShop.Pages;

public class ProductsModel : PageModel
{
    public IReadOnlyList<ProductCategory> Categories { get; private set; } = new List<ProductCategory>();

    public void OnGet()
    {
        Categories = ProductCatalog.GetCategories();
    }
}

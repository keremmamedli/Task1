using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class productModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = ProductRepository.GetProducts();
        }
    }
}

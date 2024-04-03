using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCommerce.UIX.Models;

namespace WebCommerce.UIX.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DSIIIContext _db;
        public List<Product> Products { get; set; }

        public IndexModel(ILogger<IndexModel> logger, DSIIIContext db)
        {
            _logger = logger;
            _db = db;   
        }

        public void OnGet()
        {
            Products = _db.Products.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Produkt.Data;
using Produkt.Pages.Model;

namespace Produkt.Pages.BD
{
    public class IndexModel : PageModel
    {
        private readonly Produkt.Data.ProductContext _context;

        public IndexModel(Produkt.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}

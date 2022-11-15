using Microsoft.AspNetCore.Mvc;
using Papere.Datas;
using Papere.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Papere.Pages
{
    public class VisModel : PageModel
    {
        private AppDbContext context { get; set; }

        public VisModel(AppDbContext c)
        {
            context = c;
            elePapere = c.Papere.ToList();
        }

        [BindProperty]
        public string tosearch { get; set; }

        public List<Papera> elePapere { get; set; }

    }
}

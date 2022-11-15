using Microsoft.AspNetCore.Mvc;
using Papere.Datas;
using Papere.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Papere.Pages
{
    public class CreateModel : PageModel
    {
        private AppDbContext context { get; set; }

        public CreateModel(AppDbContext c)
        {
            context = c;
        }

        [BindProperty]
        public Papera papera { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            context.Papere.Add(papera);

            context.SaveChanges();

            return RedirectToPage("Index");
        }

    }
}
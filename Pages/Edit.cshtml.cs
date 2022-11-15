using Microsoft.AspNetCore.Mvc;
using Papere.Datas;
using Papere.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Papere.Pages
{
    public class EditModel : PageModel
    {
        private AppDbContext context { get; set; }

        public EditModel(AppDbContext c)
        {
            context = c;
        }

        [BindProperty]
        public Papera papera { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null) return NotFound();

            papera = context.Papere.FirstOrDefault(papera => papera.Id == id);
            if (papera == null) return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();

            context.Attach(papera).State = EntityState.Modified;

            context.SaveChanges();

            return RedirectToPage("Index");
        }

    }
}
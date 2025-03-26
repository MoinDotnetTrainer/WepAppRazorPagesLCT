using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class UpdateBooksModel : PageModel
    {
        public DatabaseContext DatabaseContext;
        public UpdateBooksModel()
        {
            DatabaseContext = new DatabaseContext();
        }

        [BindProperty]
        public Books _Books { get; set; }
        public void OnGet(int ID)
        {
            _Books = DatabaseContext.Books.FirstOrDefault(x => x.ID == ID);
        }

        public ActionResult OnPost()
        {
            if (_Books != null)
            {
                DatabaseContext.Attach(_Books).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                int x = DatabaseContext.SaveChanges();
                if (x > 0)
                {
                    return RedirectToPage("/ViewBooks");
                }

            }
            else
            {
                return Page();
            }
            return Page();
        }
    }
}

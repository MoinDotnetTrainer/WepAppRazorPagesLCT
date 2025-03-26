using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class DeleteBooksModel : PageModel
    {
        public DatabaseContext DatabaseContext;
        public DeleteBooksModel()
        {
            DatabaseContext = new DatabaseContext();
        }

        [BindProperty]
        public Books _Books { get; set; }
        public void OnGet(int ID)
        {
            _Books = DatabaseContext.Books.FirstOrDefault(x => x.ID == ID);
        }

        public ActionResult OnPost(int ID)
        {
            var res = DatabaseContext.Books.Find(ID);
            if (res != null) {
                DatabaseContext.Books.Remove(res);
                int data = DatabaseContext.SaveChanges();
                if (data>0)
                {
                    return RedirectToPage("/ViewBooks");
                }

            }

            return Page();
            
        }
    }
}

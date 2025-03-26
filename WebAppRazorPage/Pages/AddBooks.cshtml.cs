using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class AddBooksModel : PageModel
    {
        public  DatabaseContext _databaseContext;
        public AddBooksModel()
        {
            _databaseContext = new DatabaseContext();
        }


        [BindProperty]
        public Books _Books { get; set; }
        public void OnGet()
        {
        }

        public ActionResult OnPost()
        {
            //Insert Operation
            _databaseContext.Books.Add(_Books);
           int res= _databaseContext.SaveChanges();//1
            if (res == 0)
            {
                TempData["res"] = "Something went Wrong";
            }
            else
            {
                return RedirectToPage("./ViewBooks");
            }
            return Page();
        }
    }
}

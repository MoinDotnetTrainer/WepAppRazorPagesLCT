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

        public void OnPost()
        {
            //Insert Operation
            _databaseContext.Books.Add(_Books);
            _databaseContext.SaveChanges();
        }
    }
}

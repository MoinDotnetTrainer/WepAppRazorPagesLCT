using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class ViewBooksModel : PageModel
    {
        public DatabaseContext DatabaseContext;
        public ViewBooksModel()
        {
            DatabaseContext = new DatabaseContext();
        }

        public IList<Books> _Books { get; set; }
        public void OnGet()
        {
            // insert , update  linq Queries

            _Books = (from s in DatabaseContext.Books  select s).ToList();
        }
    }
}

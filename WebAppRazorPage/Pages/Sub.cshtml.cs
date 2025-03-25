using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPage.Pages
{
    public class SubModel : PageModel
    {
        [BindProperty]
        public int txt1 { get; set; }

        [BindProperty]
        public int txt2 { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int z = txt1 - txt2;
            TempData["res"] = "sub :"+z;

        }
    }
}

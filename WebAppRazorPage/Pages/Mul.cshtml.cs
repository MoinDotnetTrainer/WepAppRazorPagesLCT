using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class MulModel : PageModel
    {
        [BindProperty]
        public MyProp Mydata { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            int z = Mydata.txt1 * Mydata.txt2;
            TempData["res"] = "Mul:" + z;
        }
    }
}

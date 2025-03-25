using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPage.Pages
{
    public class AdditionModel : PageModel
    {
        public int x { get; set; }
        public int y { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
             x =Convert.ToInt32 (Request.Form["txt1"].ToString());
             y = Convert.ToInt32(Request.Form["txt2"].ToString());
            int z = x + y;
            TempData["res"] = z;
        }
    }
}

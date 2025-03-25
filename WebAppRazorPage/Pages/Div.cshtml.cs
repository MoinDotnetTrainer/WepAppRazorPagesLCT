using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class DivModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(MyProp obj) {
            int z = obj.txt1 / obj.txt2;
            TempData["res"] = "Div Is:" + z;
        }    
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPage.Pages
{
    public class DisplayDateTimeModel : PageModel
    {
        public void OnGet()  // on form load
        {
            string res = System.DateTime.Now.ToLongTimeString();
            TempData["myres"] ="On Load:"+ res;
        }
        

        public void OnPost() //On Submit
        {
            string res = System.DateTime.Now.ToLongTimeString();
            TempData["myres"] ="On Click :"+ res;
        }
    }
}

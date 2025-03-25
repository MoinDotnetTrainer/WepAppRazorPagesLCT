using Microsoft.AspNetCore.Mvc;

namespace WebAppRazorPage.Models
{
    public class MyProp
    {
        [BindProperty]
        public int txt1 { get; set; }

        [BindProperty]
        public int txt2 { get; set; }
    }
}

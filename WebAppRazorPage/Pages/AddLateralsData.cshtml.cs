using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPage.Models;

namespace WebAppRazorPage.Pages
{
    public class AddLateralsDataModel : PageModel
    {
        public DatabaseContext DatabaseContext;
        public AddLateralsDataModel() {
        DatabaseContext = new DatabaseContext();    
        }   

        [BindProperty]
        public LateralData _LateralData { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            DatabaseContext.lateralData.Add(_LateralData);
            DatabaseContext.SaveChanges();
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppRazorPage.Models
{

    //EF Table PK

  
    public class Books
    {
        [Key]// PK and Auto Incremenet
        public int ID { get; set; }
        public string BookName { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models
{
    public class Tag
    {
        public int TagId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")] 
        public string Name { get; set; }
    }
}

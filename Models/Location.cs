using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Адреса")]
        public string Address { get; set; }
    }
}

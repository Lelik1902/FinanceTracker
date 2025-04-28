using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models
{
    public class Wallet
    {
        public int WalletId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Гаманець")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Баланс")]
        public int Balance { get; set; }

        //public string Currency { get; set; }
    }
}

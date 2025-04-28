using System.ComponentModel.DataAnnotations;

namespace FinanceTracker.Models
{
    public class Transaction
    {
        public Transaction() { }

        public int TransactionId { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Вартість")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Дата транзакції")]
        public DateTime Date { get; set; }

        [Display(Name = "Опис")]
        public string Description { get; set; }
        public int CategoryId {  get; set; }
        public int WalletId { get; set; }
        public int LocationId { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace GenerateReceipt.Models
{
    public class Receipt<T1, T2> where T2 : class
    {
        [Key]
        public T1 ReceiptIdToken { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public T2? AmountPaid { get; set; }
    }
}

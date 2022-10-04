using System.ComponentModel.DataAnnotations;

namespace GenerateReceipt.Models
{
    public class Customer<T> where T : struct
    {
        [Key]
        public int CustomerId { get; set; }

        [DataType(DataType.Text)]
        public string? CustomerName { get; set; }

        public T ReceiptIdToken { get; set; }
    }
}

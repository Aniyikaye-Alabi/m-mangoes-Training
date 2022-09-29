namespace GenerateReceipt.Models
{
    public class Customer<T> where T : struct
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public T ReceiptIdToken { get; set; }
    }
}

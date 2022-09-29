namespace GenerateReceipt.Models
{
    public class Receipt<T1, T2> where T2 : class
    {
        public T1 ReceiptIdToken { get; set; }
        public T2 AmountPaid { get; set; }
    }
}

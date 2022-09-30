namespace GenerateReceipt.ViewModels
{
    public class ListModels : CustomerViewList
    {
        public int ReceiptIdToken { get; set; }
        //public List<CustomerViewList> realCust;
        public IEnumerable<CustomerViewList>? customers;
    }
}

using GenerateReceipt.Interfaces;

namespace GenerateReceipt.ImplClasses
{
    public class ShortDate : IDate
    {
        public string date { get; set; }

        public ShortDate()
        {
            date = DateTime.Now.ToShortDateString();
        }

        public string GetDate()
        {
            return date;
        }
    }
}

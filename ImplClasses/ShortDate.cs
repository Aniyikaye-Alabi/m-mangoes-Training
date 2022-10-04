using GenerateReceipt.Interfaces;

namespace GenerateReceipt.ImplClasses
{
    public class ShortDate : Idate
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

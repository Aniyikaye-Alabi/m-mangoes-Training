using GenerateReceipt.Models;

namespace GenerateReceipt.Interfaces
{
    public interface Icrud
    {
        List<Receipt<int, string>> GetReceipt();
    }
}

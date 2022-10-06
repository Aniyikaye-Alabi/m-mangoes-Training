using GenerateReceipt.Models;

namespace GenerateReceipt.Interfaces
{
    public interface ICrudRepository
    {
        List<Receipt<int, string>> GetReceipt();
    }
}

using GenerateReceipt.Models;

namespace GenerateReceipt.Interfaces
{
    public interface ICrudRepository
    {
        List<Receipt<int, string>> GetReceipt();
        Receipt<int, string> GetAReceipt(int id);

        Receipt<int, string> Create(Receipt<int, string> receipt);
    }
}

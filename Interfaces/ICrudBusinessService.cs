using GenerateReceipt.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenerateReceipt.Interfaces
{
    public interface ICrudBusinessService
    {
        /*ActionResult<dynamic>*/
        List<Receipt<int, string>> GetAllReceipts();
        Receipt<int, string> GetAReceipt(int id);
        Receipt<int, string> CreateReceipt(Receipt<int, string> receipt);
    }
}

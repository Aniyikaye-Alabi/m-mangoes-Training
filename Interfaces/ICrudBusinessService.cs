using GenerateReceipt.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenerateReceipt.Interfaces
{
    public interface ICrudBusinessService
    {
        /*ActionResult<dynamic>*/
        List<Receipt<int, string>> GetAllReceipts();
    }
}

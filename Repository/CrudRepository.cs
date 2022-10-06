using GenerateReceipt.Data;
using GenerateReceipt.Interfaces;
using GenerateReceipt.Models;
using Microsoft.EntityFrameworkCore;

namespace GenerateReceipt.Repository
{
    public class CrudRepository : ICrudRepository
    {
        private GenerateDbContext _db;
        public CrudRepository(GenerateDbContext db)
        {
            _db = db;
        }

        public List<Receipt<int, string>> GetReceipt()
        {
           var data = _db.Receipts.ToList();
            return data;

           //return new()
           //{
           //    ReceiptIdToken = 1,
           //    AmountPaid = "fish"
           //};
        }
    }
}

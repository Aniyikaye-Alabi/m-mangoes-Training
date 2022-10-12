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

        public Receipt<int, string> Create(Receipt<int, string> receipt)
        {
            _db.Add(receipt);
            _db.SaveChanges();

            return receipt;
        }

        public Receipt<int, string> GetAReceipt(int id)
        {
            var receiptData = _db.Receipts.FirstOrDefault(x => x.ReceiptIdToken == id);
            return receiptData;
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

using GenerateReceipt.Interfaces;
using GenerateReceipt.Models;
using GenerateReceipt.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GenerateReceipt.BLL
{
    public class CrudBusinessService : ICrudBusinessService
    {
        public ICrudRepository _crud { get; set; }

        public CrudBusinessService(ICrudRepository crud )
        {
            _crud = crud;
        }

        public List<Receipt<int, string>> GetAllReceipts()
        {
            var data = _crud.GetReceipt();
            if (data == null)
            {
                throw new Exception("No receipt found");
            }
            return data;
        }

        public Receipt<int, string> GetAReceipt(int id)
        {
            var data = _crud.GetAReceipt(id);
            if (data == null)
            {
                throw new Exception("Error: No data is found, multiple receipt is present");
            }

            return data;
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw 
            //}
        }

        public Receipt<int, string> CreateReceipt(Receipt<int, string> receipt)
        {
            if (receipt == null)
            {
                throw new NullReferenceException("New receipt not available");
            }

            return _crud.Create(receipt);
        }
    }
}

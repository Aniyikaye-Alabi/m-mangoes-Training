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
            
            return data;
            //try
            //{
            //    var data = _crud.GetReceipt;
            //    if (data == null)
            //    {
            //        return "No receipt found";
            //    }

            //    return data;
            //}
            //catch (Exception ex)
            //{
            //    return ex.Message;
            //}
        }
    }
}

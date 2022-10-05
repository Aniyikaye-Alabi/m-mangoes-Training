using GenerateReceipt.Data;
using GenerateReceipt.ImplClasses;
using GenerateReceipt.Interfaces;
using GenerateReceipt.Models;
using GenerateReceipt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace GenerateReceipt.Controllers
{
    public class ReceiptController : Controller
    {
        private Idate _date { get; set; }
        private Icrud _crud { get; set; }
        private GenerateDbContext _db {get; set;}

        public ReceiptController(Idate date, GenerateDbContext db, Icrud crud)
        {
            _date = date;
            _db = db;
            this._crud = crud;
        }

        // GET: ReceiptController
        public ActionResult Index(CustomerViewList? receiptToken)
        {
            //Receipt<int, string> tellerReceipt = new Receipt<int, string>();

            //tellerReceipt.ReceiptIdToken = 0001;
            //tellerReceipt.AmountPaid = "One thousand";

            List<Receipt<int, string>> tellerList = new List<Receipt<int, string>>() {
                new Receipt<int, string> { ReceiptIdToken = 100, AmountPaid = "Two thousand" },
                new Receipt<int, string> { ReceiptIdToken = 200, AmountPaid = "One thousand" },
                new Receipt<int, string> {ReceiptIdToken = 300, AmountPaid = "Three Hundred thousand"},
                new Receipt<int, string> {ReceiptIdToken = 400, AmountPaid = "One"},
                new Receipt<int, string> {ReceiptIdToken = 500, AmountPaid = "Two"},
                new Receipt<int, string> {ReceiptIdToken = 600, AmountPaid = "Three"},
                new Receipt<int, string> {ReceiptIdToken = 700, AmountPaid = "Four"}
            };

            List<Customer<int>> customerList = new List<Customer<int>>()
            {
                new Customer<int> { CustomerId = 1, CustomerName = "Shola", ReceiptIdToken = 200 },
                new Customer<int> { CustomerId = 2, CustomerName = "Peace", ReceiptIdToken = 500 },
                new Customer<int> { CustomerId = 3, CustomerName = "Faith", ReceiptIdToken = 100 },
                new Customer<int> { CustomerId = 4, CustomerName = "Peter", ReceiptIdToken = 400 },
                new Customer<int> { CustomerId = 5, CustomerName = "George", ReceiptIdToken = 700 },
                new Customer<int> { CustomerId = 6, CustomerName = "Dan", ReceiptIdToken = 300 },
                new Customer<int> { CustomerId = 7, CustomerName = "Moses", ReceiptIdToken = 600 },
            };

            //using LINQ
            var data = from obj in tellerList join obj2 in customerList
                       on obj.ReceiptIdToken equals obj2.ReceiptIdToken
                       select new CustomerViewList
                       {
                           CustomerName = obj2.CustomerName,
                           ReceiptIdToken = obj.ReceiptIdToken,
                           AmountPaid = obj.AmountPaid
                       };
            var realdata = data.ToList();
            

            return View(realdata);
        }

        // GET: ReceiptController/Details/5
        public ActionResult Details(int id)
        {
            RunQueryC queryMsg = new RunQueryC();

            var data = queryMsg.Run();
            ViewBag.Message = data;

            return View();
            //return Content(data);
        }

        public ActionResult ShowDate()
        {
            var data = _date.GetDate();

            return Content(data);
        }

        //CreateNewReceipt
        // GET: ReceiptController/Create
        public ActionResult Create()
        {
            //List<Receipt<int, string>> newTellerList = new List<Receipt<int, string>>() {
            //    new Receipt<int, string> { ReceiptIdToken = 5, AmountPaid = "Two thousand" },
            //    new Receipt<int, string> { ReceiptIdToken = 200, AmountPaid = "Twenty thousand" },
            //};

            //var data = _db.Add(newTellerList.ToList());

            var data = _crud.GetReceipt();

            return View(data);
            //return View();
        }

        // POST: ReceiptController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceiptController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReceiptController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ReceiptController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReceiptController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

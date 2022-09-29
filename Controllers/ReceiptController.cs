using GenerateReceipt.Models;
using GenerateReceipt.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateReceipt.Controllers
{
    public class ReceiptController : Controller
    {
        // GET: ReceiptController
        public ActionResult Index()
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
            

            return View(data);
        }

        // GET: ReceiptController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReceiptController/Create
        public ActionResult Create()
        {
            return View();
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

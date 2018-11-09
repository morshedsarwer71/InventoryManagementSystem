using InventoryManagement.DataLayer.AccountingData.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagement.Controllers
{
    public class AccountingController : Controller
    {
        private readonly IJournal _journal;
        public AccountingController(IJournal journal)
        {
            _journal=journal;
        }
        // GET: Accounting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Journal()
        {
            return View();
        }
    }
}
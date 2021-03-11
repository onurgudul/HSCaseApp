using HSCaseApp.Business.Abstract;
using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSCaseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExpenseService _expenseService;
        private readonly ICostOfFutureService _costOfFutureService;
        public HomeController(IExpenseService expenseService, ICostOfFutureService costOfFutureService)
        {
            _expenseService = expenseService;
            _costOfFutureService = costOfFutureService;
        }
        public ActionResult Index()
        {
            ViewBag.ExpenseId = new SelectList(_expenseService.GetList(), "Id", "ExpenseName");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CostOfFuture costOfFuture)
        {
            _costOfFutureService.Add(costOfFuture);
            ViewBag.ExpenseId = new SelectList(_expenseService.GetList(), "Id", "ExpenseName", costOfFuture.ExpenseId);
            return RedirectToAction("GetPolicy");
        }
        public ActionResult GetPolicy()
        {
            var result = _costOfFutureService.GetList();
            return View(result);
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var result = _costOfFutureService.GetList().Where(u=>u.DocNum==id);
            return View(result);
        }



    }
}
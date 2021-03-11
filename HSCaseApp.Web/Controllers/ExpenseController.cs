using HSCaseApp.Business.Abstract;
using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSCaseApp.Web.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _expenseService;

        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }
        // GET: Expense
        public ActionResult Index()
        {
            var expense=_expenseService.GetList();
            return View(expense);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense expense)
        {
            _expenseService.Add(expense);
            return View();
        }
    }
}
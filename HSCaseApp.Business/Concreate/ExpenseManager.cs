using HSCaseApp.Business.Abstract;
using HSCaseApp.Data.Abstract;
using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Business.Concreate
{
    public class ExpenseManager : IExpenseService
    {
        private readonly IExpenseDal _expenseDal;
        public ExpenseManager(IExpenseDal expenseDal)
        {
            _expenseDal = expenseDal;
        }
        public void Add(Expense entity)
        {
            _expenseDal.Create(entity);
        }

        public void Delete(Expense entity)
        {
            _expenseDal.Delete(entity);
        }

        public Expense GetById(int id)
        {
            return _expenseDal.Get(u => u.Id == id);
        }

        public List<Expense> GetList()
        {
            return _expenseDal.GetAll();
        }

        public void Update(Expense entity)
        {
            _expenseDal.Update(entity);
        }
    }
}

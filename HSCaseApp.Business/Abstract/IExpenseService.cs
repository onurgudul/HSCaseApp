using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Business.Abstract
{
    public interface IExpenseService
    {
        Expense GetById(int id);
        List<Expense> GetList();
        void Add(Expense entity);
        void Update(Expense entity);
        void Delete(Expense entity);
    }
}

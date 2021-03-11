using HSCaseApp.Data.Abstract;
using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Data.Concreate
{
    public class ExpenseDal : Repository<Expense, AppDbContext>, IExpenseDal
    {

    }
}

using Autofac;
using HSCaseApp.Business.Abstract;
using HSCaseApp.Business.Concreate;
using HSCaseApp.Data.Abstract;
using HSCaseApp.Data.Concreate;
using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Business.Ioc_Autofac
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ExpenseManager>().As<IExpenseService>();
            builder.RegisterType<ExpenseDal>().As<IExpenseDal>();

            builder.RegisterType<CostOfFutureManager>().As<ICostOfFutureService>();
            builder.RegisterType<CostOfFutureDal>().As<ICostOfFutureDal>();
        }
    }
}

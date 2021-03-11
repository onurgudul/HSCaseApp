using HSCaseApp.Entities.DatabaseTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Business.Abstract
{
    public interface ICostOfFutureService
    {
        CostOfFuture GetById(int id);
        List<CostOfFuture> GetList();
        void Add(CostOfFuture entity);
        void Update(CostOfFuture entity);
        void Delete(CostOfFuture entity);
    }
}

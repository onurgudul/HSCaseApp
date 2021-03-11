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
    public class CostOfFutureManager : ICostOfFutureService
    {
        private readonly ICostOfFutureDal _costOfFutureDal;
        public CostOfFutureManager(ICostOfFutureDal costOfFutureDal)
        {
            _costOfFutureDal = costOfFutureDal;
        }
        public void Add(CostOfFuture entity)
        {
            _costOfFutureDal.Create(entity);
        }

        public void Delete(CostOfFuture entity)
        {
            _costOfFutureDal.Delete(entity);
        }

        public CostOfFuture GetById(int id)
        {
            return _costOfFutureDal.Get(u => u.DocNum == id);
        }

        public List<CostOfFuture> GetList()
        {
            return _costOfFutureDal.GetAll();
        }

        public void Update(CostOfFuture entity)
        {
            _costOfFutureDal.Update(entity);
        }
    }
}

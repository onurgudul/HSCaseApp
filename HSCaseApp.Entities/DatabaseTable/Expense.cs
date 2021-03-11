using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Entities.DatabaseTable
{
    public class Expense
    {
        public int Id { get; set; }
        [Display(Name = "Gider Tipi")]
        public string ExpenseName { get; set; }
        public ICollection<CostOfFuture> CostOfFutures { get; set; }

    }
}

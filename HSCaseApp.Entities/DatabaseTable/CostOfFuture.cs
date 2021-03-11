using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSCaseApp.Entities.DatabaseTable
{
    public class CostOfFuture
    {
        [Key]
        public int DocNum { get; set; }
        [Display(Name = "Muhatap Adı")]
        public string CardName { get; set; }
        [Display(Name = "Muhatap Soyadı")]
        public string CardLastName { get; set; }
        [Display(Name = "Poliçe Numarası")]
        public int PolicyNum { get; set; }
        [Display(Name = "Taksit Sayısı")]
        public int Installment { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Poliçe Başlangıç Tarihi")]
        public DateTime PolicyStartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Poliçe Bitiş Tarihi")]
        public DateTime PolicyEndDate { get; set; }
        [Display(Name = "Poliçe Açıklaması")]
        public string PolicyDescription { get; set; }
        [Display(Name = "Hesaplama Tipi")]
        public string Methodology { get; set; }
        [Display(Name = "Poliçe Tutarı")]
        public decimal PolicyPrice { get; set; }
        public int ExpenseId { get; set; }
        public virtual Expense Expense { get; set; }

    }
}

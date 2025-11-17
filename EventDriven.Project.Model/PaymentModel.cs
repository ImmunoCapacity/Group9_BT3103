using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class PaymentModel
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Grade {  get; set; }  
        public decimal AmountPaid { get; set; }
        public decimal Change { get; set; }          // NEW
        public DateTime? DatePaid { get; set; }
        public string PaymentType { get; set; }
    }
}

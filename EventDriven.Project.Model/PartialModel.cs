using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class PartialModel
    {
        public int ID { get; set; }
        public string StudentNo { get; set; }
        public string AmountPaid { get; set; }
        public string Datetime { get; set; }
        public string RemainingBalance { get; set; }
        public string PaymentMethod { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class FullPaymentModel
    {
        public int Id { get; set; }
        public string AmountPaid {  get; set; }
        public string DateTime { get; set; }
        public string PaymentMethod { get; set; }
    }
}

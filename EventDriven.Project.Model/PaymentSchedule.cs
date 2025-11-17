using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class PaymentSchedule
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal AmountDue { get; set; }
        public string Description { get; set; }
        public bool IsPaid { get; set; }

    }
}

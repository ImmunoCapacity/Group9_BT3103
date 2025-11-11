using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class PaymentHistoryModel
    {
        public int PaymentId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string GradeLevel { get; set; }
        public DateTime DatePaid { get; set; }
        public string PaymentType { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RemainingBalance { get; set; }
    }
}

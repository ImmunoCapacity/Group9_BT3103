using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class StudentPaymentInfo
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string GradeLevel { get; set; }
        public decimal TuitionFee { get; set; }
        public decimal TotalPaid { get; set; }
        public decimal RemainingBalance { get; set; }
    }
}

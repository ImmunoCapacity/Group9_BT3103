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

        // From tblStudentRegistration
        public string PaymentMethod { get; set; }

        // Payment summary
        public decimal TotalPaid { get; set; }
        public decimal RemainingBalance { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public string LastPaymentType { get; set; }

        // From tblPaymentSchedule (Next unpaid)
        public DateTime? NextDueDate { get; set; }
        public decimal? NextAmountDue { get; set; }
        public string NextScheduleDescription { get; set; }
    }
}

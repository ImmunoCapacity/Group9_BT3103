using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class StudentAssessment
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string GradeLevel { get; set; }
        public string StudentSection { get; set; }
        public decimal? GWA { get; set; }
        public string Status { get; set; }

        public string AssessmentStatus {  get; set; }

        public string EnrollmentStatus { get; set; }

        public int? RegistrationId { get; set; }
        public string RegistrationSection { get; set; }
        public string Requirements { get; set; }
        public string PaymentMethod { get; set; }

        public int? PaymentId { get; set; }
        public decimal? AmountPaid { get; set; }
        public DateTime? DatePaid { get; set; }
        public string PaymentType { get; set; }

        public int? SectionId { get; set; }

        public int? ScheduleID { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string Day { get; set; }

        public int? TeacherID { get; set; }
        public string TeacherName { get; set; }

        public int? SubjectID { get; set; }
        public string SubjectName { get; set; }
        public string Category { get; set; }

        public int? yearId { get; set; }
        public string year { get; set; }
    }
}
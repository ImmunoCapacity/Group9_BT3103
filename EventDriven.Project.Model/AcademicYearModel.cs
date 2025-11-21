using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class AcademicYearModel
    {
        public int Id { get; set; }                // Corresponds to [Id] INT
        public string YearName { get; set; }       // Corresponds to [YearName] VARCHAR(20)
        public DateTime StartDate { get; set; }    // Corresponds to [StartDate] DATE
        public DateTime EndDate { get; set; }      // Corresponds to [EndDate] DATE
        public bool IsActive { get; set; }         // Corresponds to [IsActive] BIT
        public DateTime CreatedAt { get; set; }    // Corresponds to [CreatedAt] DATETIME
        public DateTime UpdatedAt { get; set; }    // Corresponds to [UpdatedAt] DATETIME
    }

}
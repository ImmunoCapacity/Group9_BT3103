using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDriven.Project.Model
{
    public class ScheduleModel
    {
        public int ScheduleID { get; set; }
        public int SubjectID { get; set; }
        public int RoomID { get; set; }
        public int TeacherID { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }

    }
}

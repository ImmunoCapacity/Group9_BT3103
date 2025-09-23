namespace EventDriven.Project.Model
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = "";
        public string? Suffix { get; set; }
        public string Status { get; set; } = "";
        public DateTime BirthDate { get; set; }
        public string GradeLevel { get; set; } = "";
        public string? Section { get; set; }
        public string? Gender { get; set; }
        public string? Nationality { get; set; }
        public string? Email { get; set; }
        public string? LastSchool { get; set; }
        public string? LastGrade { get; set; }
        public string? Address { get; set; }
        public string? Contact { get; set; }

        public string? FatherName { get; set; }
        public string? FatherContact { get; set; }
        public string? MotherName { get; set; }
        public string? MotherContact { get; set; }
        public string? ParentAddress { get; set; }

        public string? GuardianName { get; set; }
        public string? GuardianRelationship { get; set; }
        public string? GuardianContact { get; set; }
        public string? GuardianAddress { get; set; }
        public decimal? GWA { get; set; }


    }
}

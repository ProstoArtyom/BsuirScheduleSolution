using BsuirSchedule.Domain.Enums;

namespace BsuirSchedule.Domain.Entities
{
    public class StudentGroup
    {
        public required string GroupNumber { get; set; }
        public string? FacultyAbbrev { get; set; }
        public string? FacultyName { get; set; }
        public string? SpecialityName { get; set; }
        public string? SpecialityAbbrev { get; set; }
        public int Course { get; set; }
        public EducationDegree EducationDegree { get; set; }
    }
}

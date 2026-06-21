using BsuirSchedule.Domain.Enums;

namespace BsuirSchedule.Application.DTOs
{
    public class StudentGroupSummary
    {
        public required string Number { get; set; }
        public string? FacultyAbbrev { get; set; }
        public string? SpecialityAbbrev { get; set; }
        public int? Course { get; set; }
    }
}

namespace BsuirSchedule.Application.DTOs
{
    public class ScheduleSummary
    {
        public string[] Auditories { get; set; } = [];
        public string? StartLessonTime { get; set; }
        public string? EndLessonTime { get; set; }
        public string? LessonTypeAbbrev { get; set; }
        public string? Note { get; set; }
        public int? NumSubGroup { get; set; }
        public string? Subject { get; set; }
        public string? SubjectFullName { get; set; }
        public IReadOnlyList<EmployeeSummary> Employees { get; set; } = [];
        public string? StartLessonDate { get; set; }
        public string? EndLessonDate { get; set; }
        public bool? Announcement { get; set; }
        public bool? Split { get; set; }
    }
}
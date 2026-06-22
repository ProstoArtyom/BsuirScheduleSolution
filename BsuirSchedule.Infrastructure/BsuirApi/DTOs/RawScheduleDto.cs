namespace BsuirSchedule.Infrastructure.BsuirApi.DTOs
{
    public class RawScheduleDto
    {
        public string[] Auditories { get; set; } = [];
        public string? StartLessonTime { get; set; }
        public string? EndLessonTime { get; set; }
        public string? LessonTypeAbbrev { get; set; }
        public string? Note { get; set; }
        public int? NumSubGroup { get; set; }
        public string? Subject { get; set; }
        public string? SubjectFullName { get; set; }
        public int[] WeekNumber { get; set; } = [];
        public RawEmployeeDto[] Employees { get; set; } = [];
        public string? DateLesson { get; set; }
        public string? StartLessonDate { get; set; }
        public string? EndLessonDate { get; set; }
        public bool? Announcement { get; set; }
        public bool? Split { get; set; }
    }
}

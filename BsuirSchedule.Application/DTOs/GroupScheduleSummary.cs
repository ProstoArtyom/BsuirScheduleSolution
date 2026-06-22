namespace BsuirSchedule.Application.DTOs
{
    public class GroupScheduleSummary
    {
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public IReadOnlyDictionary<string, IReadOnlyList<ScheduleSummary>> Schedules { get; set; } 
            = new Dictionary<string, IReadOnlyList<ScheduleSummary>>();

        public string? StartExamsDate { get; set; }
        public string? EndExamsDate { get; set; }
        public IReadOnlyList<ScheduleSummary> Exams { get; set; } = [];
    }
}
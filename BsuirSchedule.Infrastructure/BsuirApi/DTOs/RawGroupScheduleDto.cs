namespace BsuirSchedule.Infrastructure.BsuirApi.DTOs
{
    public class RawGroupScheduleDto
    {
        public RawStudentGroupDto? StudentGroupDto { get; set; }
        public IReadOnlyDictionary<string, IReadOnlyList<RawScheduleDto>> Schedules { get; set; } = new Dictionary<string, IReadOnlyList<RawScheduleDto>>();
        public IReadOnlyList<RawScheduleDto> Exams { get; set; } = new List<RawScheduleDto>();
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public string? StartExamsDate { get; set; }
        public string? EndExamsDate { get; set; }
        public string? CurrentTerm { get; set; }
        public string? NextTerm { get; set; }
        public string? CurrentPeriod { get; set; }
        public bool? IsZaochOrDist { get; set; }
    }
}

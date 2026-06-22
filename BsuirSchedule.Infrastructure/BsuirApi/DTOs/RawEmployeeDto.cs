namespace BsuirSchedule.Infrastructure.BsuirApi.DTOs
{
    public class RawEmployeeDto
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public Uri? PhotoLink { get; set; }
        public string? Degree { get; set; }
        public string? DegreeAbbrev { get; set; }
        public string? Rank { get; set; }
        public string? Email { get; set; }
        public string? UrlId { get; set; }
        public string? CalendarId { get; set; }
        public bool? Chief { get; set; }
    }
}
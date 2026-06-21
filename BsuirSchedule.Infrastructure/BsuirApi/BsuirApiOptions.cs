namespace BsuirSchedule.Infrastructure.BsuirApi
{
    public class BsuirApiOptions
    {
        public const string SectionName = "BsuirApi";

        public required string BaseUrl { get; set; }
        public int TimeoutSeconds { get; set; } = 10;
    }
}

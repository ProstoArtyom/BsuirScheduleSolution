namespace BsuirSchedule.TelegramBot
{
    public class BotOptions
    {
        public static string SectionName => "TelegramBot";

        public required string Token { get; set; }
        public required string ScheduleApiBaseUrl { get; set; }
    }
}

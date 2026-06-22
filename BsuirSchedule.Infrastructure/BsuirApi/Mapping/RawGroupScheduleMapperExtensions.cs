using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;

namespace BsuirSchedule.Infrastructure.BsuirApi.Mapping
{
    public static class RawGroupScheduleMapperExtensions
    {
        public static GroupScheduleSummary ToSummary(this RawGroupScheduleDto raw)
        {
            return new GroupScheduleSummary
            {
                StartDate = raw.StartDate,
                EndDate = raw.EndDate,
                Schedules = raw.Schedules.ToSummaryDictionary(),

                StartExamsDate = raw.StartExamsDate,
                EndExamsDate = raw.EndExamsDate,
                Exams = raw.Exams.ToSummaryList()
            };
        }
    }
}

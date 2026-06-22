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

            };
        }
    }
}

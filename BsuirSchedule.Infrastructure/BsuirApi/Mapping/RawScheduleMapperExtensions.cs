using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;

namespace BsuirSchedule.Infrastructure.BsuirApi.Mapping
{
    public static class RawScheduleMapperExtensions
    {
        public static ScheduleSummary ToSummary(this RawScheduleDto rawScheduleDto)
        {
            return new ScheduleSummary
            {
                Auditories = rawScheduleDto.Auditories,
                StartLessonTime = rawScheduleDto.StartLessonTime,
                EndLessonTime = rawScheduleDto.EndLessonDate,
                LessonTypeAbbrev = rawScheduleDto.LessonTypeAbbrev,
                Note = rawScheduleDto.Note,
                NumSubGroup = rawScheduleDto.NumSubGroup,
                Subject = rawScheduleDto.Subject,
                SubjectFullName = rawScheduleDto.SubjectFullName,
                Employees = rawScheduleDto.Employees.ToSummaryList(),
                StartLessonDate = rawScheduleDto.StartLessonDate,
                EndLessonDate = rawScheduleDto.EndLessonDate,
                Announcement = rawScheduleDto.Announcement,
                Split = rawScheduleDto.Split
            };
        }

        public static IReadOnlyList<ScheduleSummary> ToSummaryList(this IReadOnlyList<RawScheduleDto> rawScheduleDtos)
        {
            return rawScheduleDtos
                .Select(s => s.ToSummary())
                .ToList();
        }

        public static IReadOnlyDictionary<string, IReadOnlyList<ScheduleSummary>> ToSummaryDictionary(
            this IReadOnlyDictionary<string, IReadOnlyList<RawScheduleDto>> rawScheduleDtoDict)
        {
            return rawScheduleDtoDict.ToDictionary(
                kvp => kvp.Key,
                kvp => kvp.Value.ToSummaryList()
            );
        }
    }
}

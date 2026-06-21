using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;

namespace BsuirSchedule.Infrastructure.BsuirApi.Mapping
{
    public static class RawStudentGroupMapperExtensions
    {
        public static StudentGroupSummary ToSummary(this RawStudentGroupDto raw)
        {
            return new StudentGroupSummary
            {
                Number = raw.Name,
                FacultyAbbrev = raw.FacultyAbbrev,
                SpecialityAbbrev = raw.SpecialityAbbrev,
                Course = raw.Course
            };
        }
    }
}

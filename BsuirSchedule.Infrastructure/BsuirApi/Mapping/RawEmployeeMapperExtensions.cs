using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;

namespace BsuirSchedule.Infrastructure.BsuirApi.Mapping
{
    public static class RawEmployeeMapperExtensions
    {
        public static EmployeeSummary ToSummary(this RawEmployeeDto rawEmployeeDto)
        {
            return new EmployeeSummary
            {
                FirstName = rawEmployeeDto.FirstName,
                MiddleName = rawEmployeeDto.MiddleName,
                LastName = rawEmployeeDto.LastName
            };
        }

        public static IReadOnlyList<EmployeeSummary> ToSummaryList(this IEnumerable<RawEmployeeDto> rawEmployeeDtos)
        {
            return rawEmployeeDtos
                .Select(e => e.ToSummary())
                .ToList();
        }
    }
}

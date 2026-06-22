using BsuirSchedule.Application.DTOs;

namespace BsuirSchedule.Application.Abstractions
{
    public interface IBsuirClient
    {
        Task<IReadOnlyList<StudentGroupSummary>> GetAllGroupsAsync(CancellationToken ct);
        Task<GroupScheduleSummary?> GetGroupScheduleAsync(string groupNumber, CancellationToken ct);
    }
}

using BsuirSchedule.Application.Abstractions;
using BsuirSchedule.Application.DTOs;

namespace BsuirSchedule.Application.Services
{
    public class GroupService : IGroupService
    {
        private readonly IBsuirClient _bsuirClient;
        public GroupService(IBsuirClient bsuirClient)
        {
            _bsuirClient = bsuirClient;
        }

        public async Task<IReadOnlyList<StudentGroupSummary>> GetAllGroupsAsync(CancellationToken ct)
        {
            return await _bsuirClient.GetAllGroupsAsync(ct);
        }
    }
}

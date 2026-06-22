using BsuirSchedule.Application.Abstractions;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;
using System.Net.Http.Json;
using System.Text.Json;
using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.Mapping;
using Microsoft.AspNetCore.WebUtilities;

namespace BsuirSchedule.Infrastructure.BsuirApi
{
    public class BsuirClient : IBsuirClient
    {
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNameCaseInsensitive = true
        };

        private readonly HttpClient _httpClient;
        public BsuirClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IReadOnlyList<StudentGroupSummary>> GetAllGroupsAsync(CancellationToken ct)
        {
            var raw = _httpClient.GetFromJsonAsAsyncEnumerable<RawStudentGroupDto>(
                "student-groups", JsonOptions, ct);

            return await raw
                .Select(g => g.ToSummary())
                .ToListAsync(ct);
        }

        public async Task<GroupScheduleSummary?> GetGroupScheduleAsync(string groupNumber, CancellationToken ct)
        {
            var url = QueryHelpers.AddQueryString("schedule", new Dictionary<string, string?>
            {
                { "studentGroup", groupNumber }
            });
            
            var raw = await _httpClient.GetFromJsonAsync<RawGroupScheduleDto>(url, JsonOptions, ct);

            return raw?.ToSummary();
        }
    }
}

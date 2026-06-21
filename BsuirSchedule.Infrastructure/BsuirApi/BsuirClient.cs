using BsuirSchedule.Application.Abstractions;
using BsuirSchedule.Infrastructure.BsuirApi.DTOs;
using System.Net.Http.Json;
using System.Text.Json;
using BsuirSchedule.Application.DTOs;
using BsuirSchedule.Infrastructure.BsuirApi.Mapping;

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
            var raw = await _httpClient.GetFromJsonAsync<List<RawStudentGroupDto>>(
                "student-groups", JsonOptions, ct) ?? [];

            return raw
                .Select(g => g.ToSummary())
                .ToList();
        }
    }
}

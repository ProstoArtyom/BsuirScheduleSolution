using BsuirSchedule.Application.Abstractions;
using BsuirSchedule.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace BsuirSchedule.WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GroupsСontroller : ControllerBase
    {
        private readonly IGroupService _groupService;
        public GroupsСontroller(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<StudentGroupSummary>>> GetAllAsync(CancellationToken ct)
        {
            var groupList = await _groupService.GetAllGroupsAsync(ct);
            return Ok(groupList);
        }
    }
}

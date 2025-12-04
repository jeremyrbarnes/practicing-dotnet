using Microsoft.AspNetCore.Mvc;
using ConferenceAttendees.Api.Data;
using ConferenceAttendees.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
public class JobRoleController : ControllerBase
{
    private readonly ConferenceDbContext _context;

    public JobRoleController(ConferenceDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/jobroles")]
    public async Task<ActionResult<IEnumerable<JobRole>>> GetJobRoles()
    {
        return await _context.JobRoles.ToListAsync();
    }
}
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

    [HttpPost]
    [Route("api/jobroles")]
    public async Task<ActionResult<JobRole>> CreateJobRole(JobRole jobRole)
    {
        _context.JobRoles.Add(jobRole);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetJobRoles), new { id = jobRole.Id }, jobRole);
    }
    
    [HttpPut]
    [Route("api/jobroles/{id}")]
    public async Task<IActionResult> UpdateJobRole(Guid id, JobRole jobRole)
    {
        if (id != jobRole.Id)
        {
            return BadRequest();
        }
        _context.Entry(jobRole).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete]
    [Route("api/jobroles/{id}")]
    public async Task<IActionResult> DeleteJobRole(Guid id)
    {
        var jobRole = await _context.JobRoles.FindAsync(id);
        if (jobRole == null)
        {
            return NotFound();
        }
        _context.JobRoles.Remove(jobRole);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
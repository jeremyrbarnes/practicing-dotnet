using Microsoft.AspNetCore.Mvc;
using ConferenceAttendees.Api.Data;
using ConferenceAttendees.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
public class ReferralSourceController : ControllerBase
{
    private readonly ConferenceDbContext _context;

    public ReferralSourceController(ConferenceDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/referralsources")]
    public async Task<ActionResult<IEnumerable<ReferralSource>>> GetReferralSources()
    {
        return await _context.ReferralSources.ToListAsync();
    }
}
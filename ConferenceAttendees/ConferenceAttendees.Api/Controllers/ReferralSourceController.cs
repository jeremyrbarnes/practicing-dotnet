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

    [HttpPost]
    [Route("api/referralsources")]
    public async Task<ActionResult<ReferralSource>> CreateReferralSource(ReferralSource referralSource)
    {
        _context.ReferralSources.Add(referralSource);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetReferralSources), new { id = referralSource.Id }, referralSource);
    }

    [HttpPut]
    [Route("api/referralsources/{id}")]
    public async Task<IActionResult> UpdateReferralSource(Guid id, ReferralSource referralSource)
    {
        if (id != referralSource.Id)
        {
            return BadRequest();
        }
        _context.Entry(referralSource).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete]
    [Route("api/referralsources/{id}")]
    public async Task<IActionResult> DeleteReferralSource(Guid id)
    {
        var referralSource = await _context.ReferralSources.FindAsync(id);
        if (referralSource == null)
        {
            return NotFound();
        }
        _context.ReferralSources.Remove(referralSource);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
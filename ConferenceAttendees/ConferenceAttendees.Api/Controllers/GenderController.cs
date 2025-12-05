using Microsoft.AspNetCore.Mvc;
using ConferenceAttendees.Api.Data;
using ConferenceAttendees.Api.Data.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
public class GenderController : ControllerBase
{
    private readonly ConferenceDbContext _context;

    public GenderController(ConferenceDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("api/genders")]
    public async Task<ActionResult<IEnumerable<Gender>>> GetGenders()
    {
        return await _context.Genders.ToListAsync();
    }

    [HttpPost]
    [Route("api/genders")]
    public async Task<ActionResult<Gender>> CreateGender(Gender gender)
    {
        _context.Genders.Add(gender);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetGenders), new { id = gender.Id }, gender);
    }

    [HttpPut]
    [Route("api/genders/{id}")]
    public async Task<IActionResult> UpdateGender(Guid id, Gender gender)
    {
        if (id != gender.Id)
        {
            return BadRequest();
        }
        _context.Entry(gender).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete]
    [Route("api/genders/{id}")]
    public async Task<IActionResult> DeleteGender(Guid id)
    {
        var gender = await _context.Genders.FindAsync(id);
        if (gender == null)
        {
            return NotFound();
        }
        _context.Genders.Remove(gender);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}
using Microsoft.AspNetCore.Mvc;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Data;

namespace Mango.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponAPIController : ControllerBase
    {
        private readonly ILogger<CouponAPIController> _logger;
        private readonly AppDbContext _db;

        public CouponAPIController(ILogger<CouponAPIController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Coupon>> GetAll()
        {
            try 
            {
                var coupons = _db.Coupons.ToList();
                return Ok(coupons);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving coupons");
                return StatusCode(500, "Internal server error");    
            }
        }

        [HttpGet("{code}", Name = nameof(GetByCode))]
        public ActionResult<Coupon> GetByCode(string code)
        {
            var coupon = _db.Coupons.FirstOrDefault(c => string.Equals(c.CouponCode, code, StringComparison.OrdinalIgnoreCase));
            if (coupon == null) return NotFound();
            return Ok(coupon);
        }
    }
}
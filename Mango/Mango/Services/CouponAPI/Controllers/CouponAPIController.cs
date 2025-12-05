using Microsoft.AspNetCore.Mvc;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models.Dto;

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
        public ActionResult<ResponseDto> GetAll()
        {
            try 
            {
                var coupons = _db.Coupons.ToList();
                return Ok(new ResponseDto() { Result = coupons});
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving coupons");
                return StatusCode(500, "Internal server error");    
            }
        }

        [HttpGet("{id}", Name = nameof(GetById))]
        public ActionResult<ResponseDto> GetById(int id)
        {
            var coupon = _db.Coupons.FirstOrDefault(c => c.CouponId == id);
            if (coupon == null) return NotFound();
            return Ok(new ResponseDto() { Result = coupon });
        }

        // [HttpGet("{code}", Name = nameof(GetByCode))]
        // public ActionResult<Coupon> GetByCode(string code)
        // {
        //     var coupon = _db.Coupons.FirstOrDefault(c => string.Equals(c.CouponCode, code, StringComparison.OrdinalIgnoreCase));
        //     if (coupon == null) return NotFound();
        //     return Ok(coupon);
        // }
    }
}
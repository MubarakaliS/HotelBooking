using HotelBooking.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingController : ControllerBase
    {
        private readonly IHotelBookingService _hotelBookingService;
        public HotelBookingController(IHotelBookingService hotelBookingService) 
        { 
            _hotelBookingService = hotelBookingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHotelList()
        {
            var result= await _hotelBookingService.GetHotelList();
            return Ok(result);
        }
    }
}

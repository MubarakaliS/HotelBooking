using Context.Model;
using HotelBooking.Repository.Interface;
using HotelBooking.Service.Interface;

namespace HotelBooking.Service
{
    public class HotelBookingService:IHotelBookingService
    {
        private readonly IHotelBookingRepo _hotelBookingRepo;
        public HotelBookingService(IHotelBookingRepo hotelBookingRepo)
        {
            _hotelBookingRepo = hotelBookingRepo;
        }

        public async Task<List<HotelModel>> GetHotelList()
        {
            return await _hotelBookingRepo.GetHotelList();
        }
    }
}

using Context.Model;

namespace HotelBooking.Service.Interface
{
    public interface IHotelBookingService
    {
        Task<List<HotelModel>> GetHotelList();
    }
}

using Context.Model;
using Dapper;
using HotelBooking.Repository.Interface;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
namespace HotelBooking.Repository
{
    public class HotelBookingRepo : IHotelBookingRepo
    {
        private readonly IConfiguration _configuration;
        public HotelBookingRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<List<HotelModel>> GetHotelList()
        {
            var connectionString = _configuration.GetConnectionString("DatabaseConnectionString");
            using IDbConnection db = new SqlConnection(connectionString);
            string sql = "SELECT Id, Name FROM Users";
            return (await db.QueryAsync<HotelModel>(sql)).AsList();
        }
    }
}

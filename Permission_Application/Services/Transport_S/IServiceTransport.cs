using VehicleManagement_Application.Dto_s;
using VehicleManagement_Domen.Entityes;

namespace Permission_Application.Services.Teacher_S
{
    public interface IServiceTransport
    {
        public Task<IEnumerable<Transport>> GetAllAsync();
        public Task<Transport> GetById(int Id);
        public Task<Transport> CreateAsync(TransportDto transportDto, string formFile);
        public Task<Transport> UpdateAsync(int id, TransportDto transportDto ,string fromFile);
        public Task<bool> DeleteAsync(int id);
    }
}

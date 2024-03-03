using Mapster;
using Microsoft.AspNetCore.Http;
using Permission_Application.Abstractions.Repositories;
using VehicleManagement_Application.Dto_s;
using VehicleManagement_Domen.Entityes;

namespace Permission_Application.Services.Teacher_S
{
    public class ServiceTransport : IServiceTransport
    {
        private readonly ITransportRepositories _transportRepositories;
        public ServiceTransport(ITransportRepositories transportRepositories) => _transportRepositories = transportRepositories;

        public async Task<Transport> CreateAsync(TransportDto transportDto, string fieldInfo)
        {
            var newtrans = transportDto.Adapt<Transport>();
            newtrans.ImageUrl = fieldInfo;
            newtrans.CreatedAt = DateTime.UtcNow;
            return await _transportRepositories.CreateAsync(newtrans);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var find = await _transportRepositories.GetAsync(id);
            return find != null;
        }

        public async Task<IEnumerable<Transport>> GetAllAsync()
        {
            return await _transportRepositories.GetAllAsync();
        }

        public async Task<Transport> GetById(int Id)
        {
                var result = await _transportRepositories.GetAsync(Id);
            return result != null ? result : null;
        }

        public async Task<Transport> UpdateAsync(int id, TransportDto transportDto, string fileinfo)
        {
            var newtrans = await _transportRepositories.GetAsync(id);

            if( newtrans != null)
            {
                newtrans.Name = transportDto.Name;
                newtrans.Description = transportDto.Description;
                newtrans.Type = transportDto.Type;
                newtrans.Number = transportDto.Number;
                newtrans.Fuel_type = transportDto.Fuel_type;
                newtrans.ImageUrl = fileinfo;
                newtrans.UpdatedAt = DateTime.UtcNow;
                newtrans.Price = transportDto.Price;

                return await _transportRepositories.UpdateAsync(newtrans);
            }
            return null;
        }
    }
}
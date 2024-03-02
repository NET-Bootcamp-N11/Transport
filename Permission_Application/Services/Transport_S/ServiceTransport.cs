using Mapster;
using Microsoft.AspNetCore.Http;
using Permission_Application.Abstractions.Repositories;
using Permission_Application.Dto_s;
using Permission_Domen.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
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
            return await _transportRepositories.GetAsync(Id);
        }

        public async Task<Transport> UpdateAsync(int id, TransportDto transportDto)
        {
            var newtrans = await _transportRepositories.GetAsync(id);

            newtrans.Name = transportDto.Name;
            newtrans.Description = transportDto.Description;
            newtrans.Type = transportDto.Type;
            newtrans.Number = transportDto.Number;
            newtrans.Fuel_type = transportDto.Fuel_type;
            newtrans.UpdatedAt = DateTime.UtcNow;
            newtrans.Price = transportDto.Price;

            return await _transportRepositories.UpdateAsync(newtrans);

        }
    }
}
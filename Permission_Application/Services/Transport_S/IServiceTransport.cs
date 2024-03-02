using Microsoft.AspNetCore.Http;
using Permission_Application.Abstractions.Generic;
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
    public interface IServiceTransport
    {
        public Task<IEnumerable<Transport>> GetAllAsync();
        public Task<Transport> GetById(int Id);
        public Task<Transport> CreateAsync(TransportDto transportDto,string formFile);
        public Task<Transport> UpdateAsync(int id , TransportDto transportDto);
        public Task<bool> DeleteAsync(int id);
    }
}

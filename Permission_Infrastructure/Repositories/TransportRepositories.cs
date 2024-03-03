using Permission_Application.Abstractions.Repositories;
using Permission_Infrastructure;
using Permission_Infrastructure.Generic;
using VehicleManagement_Domen.Entityes;

namespace VehicleManagement_Infrastructure.Repositories
{
    public class TransportRepositories : GenericRepositories<Transport>, ITransportRepositories
    {
        public TransportRepositories(AppDbContext app) : base(app)
        {
        }
    }
}

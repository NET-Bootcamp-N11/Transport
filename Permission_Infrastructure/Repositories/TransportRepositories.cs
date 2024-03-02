using Permission_Application.Abstractions.Repositories;
using Permission_Infrastructure;
using Permission_Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

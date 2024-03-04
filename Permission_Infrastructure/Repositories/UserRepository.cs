using Permission_Application.Abstractions.Repositories;
using Permission_Domen.Entityes;
using Permission_Infrastructure.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement_Infrastructure.Repositories
{
    public class UserRepository : GenericRepositories<User>,IUserRepositories
    {
        public UserRepository(AppDbContext app) : base(app)
        {
        }
    }
}

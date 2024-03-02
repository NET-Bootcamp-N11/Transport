using Permission_Domen.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement_Domen.Entityes
{
    public class Transport:AuditTable
    {

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? Number {  get; set; }
        public string? Type { get; set; }
        public string? Fuel_type  { get; set; }
        public string? Weight { get; set; }
        public string? Price {  get; set; }
        public string? Year_Of_Creation { get; set; }
    }
}

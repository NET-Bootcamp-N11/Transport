using Permission_Domen.Entityes;
using Permission_Infrastructure;
using VehicleManagement_Domen.Entityes;

namespace Permission_APi.Data
{
    public static class SeedDataExtentions
    {
        public static async Task InitiliazeDataAsync(this IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetRequiredService<AppDbContext>();
            if (!db.Transports.Any())
            {
                List<Transport> students = [
                     new Transport
                     {
                         Name = "Toyota Camry",
                         Description = "Sedan car",
                         ImageUrl = "https://example.com/toyota_camry.jpg",
                         Number = "ABC123",
                         Type = "Sedan",
                         Fuel_type = "Petrol",
                         Weight = "1500 kg",
                         Price = "$25000",
                         Year_Of_Creation = "2022"
                     },
                     new Transport
                     {
                         Name = "Honda Civic",
                         Description = "Compact car",
                         ImageUrl = "https://example.com/honda_civic.jpg",
                         Number = "XYZ456",
                         Type = "Compact",
                         Fuel_type = "Petrol",
                         Weight = "1200 kg",
                         Price = "$20000",
                         Year_Of_Creation = "2021"
                     },
                     new Transport
                     {
                        Name = "Ford Mustang",
                        Description = "Muscle car",
                        ImageUrl = "https://example.com/ford_mustang.jpg",
                        Number = "DEF789",
                        Type = "Muscle",
                        Fuel_type = "Petrol",
                        Weight = "1700 kg",
                        Price = "$35000",
                        Year_Of_Creation = "2020"
                     },

                     new Transport
                     {
                         Name = "Tesla Model S",
                         Description = "Electric car",
                         ImageUrl = "https://example.com/tesla_model_s.jpg",
                         Number = "GHI012",
                         Type = "Electric",
                         Fuel_type = "Electric",
                         Weight = "2100 kg",
                         Price = "$70000",
                         Year_Of_Creation = "2019"
                     },

                     new Transport
                     {
                         Name = "BMW X5",
                         Description = "SUV",
                         ImageUrl = "https://example.com/bmw_x5.jpg",
                         Number = "JKL345",
                         Type = "SUV",
                         Fuel_type = "Petrol",
                         Weight = "2000 kg",
                         Price = "$60000",
                         Year_Of_Creation = "2021"
                     }];
                db.Transports.AddRange(students);
                await db.SaveChangesAsync();
            }
        }

    }
}

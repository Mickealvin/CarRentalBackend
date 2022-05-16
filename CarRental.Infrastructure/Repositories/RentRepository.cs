using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using CarRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Repositories
{
    public class RentRepository : BaseRepository<Rent>, IRentRepository
    {
        public RentRepository(CarRentalContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> IsAvailableForRent(int vehicleId, DateTime rentDate, DateTime returnDate)
        {
            // verificar si no hay rentas para ese vehiculo, en ese rango de fechas

        }
    }
}

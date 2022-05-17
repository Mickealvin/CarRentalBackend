using CarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Interfaces
{
    public interface IRentRepository: IRepository<Rent>
    {
        Task<bool> IsAvailableForRent(int vehicleId, DateTime rentDate, DateTime returnDate);
    }
}

using CarRental.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<VehicleType> VehicleTypeRepository { get; }
        IRepository<Brand> BrandRepository { get; }
        IRepository<Model> ModelRepository { get; }
        IRepository<FuelType> FuelTypeRepository { get; }
        IRepository<Vehicle> VehicleRepository { get; }
        IRepository<Client> ClientRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IInspectionRepository InspectionRepository { get; }
        IRentRepository RentRepository { get; }
        void SaveChanges();
        Task<int> SaveChangesAsync();
    }
}

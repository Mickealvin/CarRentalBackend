using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using CarRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarRentalContext _context;
        public IRepository<VehicleType> VehicleTypeRepository { get; }
        public IRepository<Brand> BrandRepository { get; }
        public IRepository<Model> ModelRepository { get; }
        public IRepository<FuelType> FuelTypeRepository { get; }
        public IRepository<Vehicle> VehicleRepository { get; }
        public IRepository<Client> ClientRepository { get; }
        public IRepository<Employee> EmployeeRepository { get; }
        public IInspectionRepository InspectionRepository { get; }
        public IRentRepository RentRepository { get; }
        public UnitOfWork(
            CarRentalContext context,
            IRepository<VehicleType> vehicleTypeRepository,
            IRepository<Brand> brandRepository,
            IRepository<Model> modelRepository,
            IRepository<FuelType> fuelTypeRepository,
            IRepository<Vehicle> vehicleRepository,
            IRepository<Client> clientRepository,
            IRepository<Employee> employeeRepository,
            IInspectionRepository inspectionRepository,
            IRentRepository rentRepository
            )
        {
            _context = context;
            VehicleTypeRepository = vehicleTypeRepository;
            BrandRepository = brandRepository;
            ModelRepository = modelRepository;
            FuelTypeRepository = fuelTypeRepository;
            VehicleRepository = vehicleRepository;
            ClientRepository = clientRepository;
            EmployeeRepository = employeeRepository;
            InspectionRepository = inspectionRepository;
            RentRepository = rentRepository;
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return  _context.SaveChangesAsync();
        }
    }
}

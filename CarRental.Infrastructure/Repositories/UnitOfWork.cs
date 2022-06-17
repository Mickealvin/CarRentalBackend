using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using CarRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public IAuthRepository AuthRepository { get; }

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
            IRentRepository rentRepository,
            IAuthRepository authRepository,
            IServiceProvider serviceProvider
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
            AuthRepository = authRepository;
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

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            var repositoryProperty = this.GetType().GetProperties().FirstOrDefault(x => x.PropertyType.GenericTypeArguments.FirstOrDefault() == typeof(T));
            if (repositoryProperty == null) return new BaseRepository<T>(this._context);
            return repositoryProperty.GetValue(this) as IRepository<T>;
        }
    }
}

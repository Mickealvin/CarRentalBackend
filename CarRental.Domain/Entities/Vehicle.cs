using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Vehicle:BaseEntity
    {
        public string Description { get; set; }
        public int ChassisNumber { get; set; }
        public int EngineNumber { get; set; }
        public int PlateNumber { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
    }
}

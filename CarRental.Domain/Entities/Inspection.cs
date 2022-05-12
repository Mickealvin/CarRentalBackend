using CarRental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.Entities
{
    public class Inspection: BaseEntity
    {
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public bool HasScratches { get; set; }
        public FuelQuantity FuelQuantity { get; set; }
        public bool HasSpareTire { get; set; }
        public bool HasManualJack { get; set; }
        public bool HasGlassBreakage { get; set; }
        public bool FirstTireCondition { get; set; }
        public bool SecondTireCondition { get; set; }
        public bool ThirdTireCondition { get; set; }
        public bool FourthTireCondition { get; set; }
        public DateTime InspectionDate { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public InspectionType InspectionType { get; set; }
    }
}

using CarRental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.Domain.DTOs
{
    public class CheckVehicleAvaiabilityDto
    {
        public int vehicleId { get; set; }
        public int clientId { get; set; }
        public DateTime inspectionDate { get; set; }
        public InspectionType type { get; set; }
    }
}

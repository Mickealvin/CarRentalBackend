using CarRental.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.API.DTOs
{
    public class CheckVehicleAvaiabilityDto
    {
        public int idVehicle { get; set; }
        public int idClient { get; set; }
        public DateTime inspectionDate { get; set; }
        public InspectionType type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Domain.DTOs
{
    public class CheckRentAvaiabilityDto
    {
        public int idVehicle { get; set; }
        public int idClient { get; set; }
        public DateTime rentDate { get; set; }
        public DateTime returnDate { get; set; }
    }
}

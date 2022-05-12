using CarRental.API.Concrete;
using CarRental.API.DTOs;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspectionController : BaseController<Inspection>
    {
        private readonly IUnitOfWork _unitOfWork;
        public InspectionController(IUnitOfWork unitOfWork) : base(unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet("available")]
        public async Task<IActionResult> CheckVehicleAvaiability([FromQuery] CheckVehicleAvaiabilityDto data)
        {
            var response = await _unitOfWork.InspectionRepository.CheckVehicleAvailability(data.idVehicle, data.idClient, data.inspectionDate, data.type);
            return Ok(new ResponseDto<bool>(response));
        }
    }
}

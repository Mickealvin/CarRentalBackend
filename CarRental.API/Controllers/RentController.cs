﻿using CarRental.API.Concrete;
using CarRental.API.DTOs;
using CarRental.Domain.DTOs;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : BaseController<Rent>
    {
        private readonly IUnitOfWork _unitOfWork;
        public RentController(IUnitOfWork unitOfWork) : base(unitOfWork) => _unitOfWork = unitOfWork;

        [HttpGet("available")]
        public async Task<IActionResult> IsAvailableForRent([FromQuery] IsAvailableForRentDto dto)
        {
            var result = await _unitOfWork.RentRepository.IsAvailableForRent(dto.VehicleId, dto.RentDate, dto.ReturnDate);
            return Ok(new ResponseDto<bool>(result, true));
        }

        [HttpPut("{rentId}/complete")]
        public async Task<IActionResult> CompleteRent([FromRoute] int rentId)
        {
            await _unitOfWork.RentRepository.CompleteRent(rentId);
            await _unitOfWork.SaveChangesAsync();
            return Ok(new ResponseDto<bool>(true));
        }
    }
}

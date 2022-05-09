using CarRental.API.Abstract;
using CarRental.API.DTOs;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRental.API.Concrete
{
    [ApiController]
    public abstract class BaseController<T> : ControllerBase, IBaseController<T> where T: BaseEntity
    {
        private readonly IRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public BaseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            string name = typeof(T).Name + "Repository";
            _repository = (IRepository<T>)unitOfWork.GetType().GetProperty(name).GetValue(unitOfWork, null);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T _object)
        {
            await _repository.Insert(_object);
            await _unitOfWork.SaveChangesAsync();
            return Ok(new ResponseDto<bool>(true));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            await _repository.Delete(Id);
            await _unitOfWork.SaveChangesAsync();
            return Ok(new ResponseDto<bool>(true));
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            var data = await _repository.GetById(Id);
            await _unitOfWork.SaveChangesAsync();
            var response = new ResponseDto<T>(null);
            if(data == null)
            {
                response.Success = false;
                return NotFound(response);
            }

            response.Data = data;
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _repository.GetAll();
            await _unitOfWork.SaveChangesAsync();
            return Ok(new ResponseDto<IEnumerable<T>>(data));
        }

        public async Task<IActionResult> Update([FromBody] T _object)
        {
            _repository.Update(_object);
            await _unitOfWork.SaveChangesAsync();
            return Ok(new ResponseDto<bool>(true));
        }
    }
}

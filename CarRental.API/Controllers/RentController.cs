using CarRental.API.Concrete;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : BaseController<Rent>
    {
        public RentController(IUnitOfWork unitOfWork): base(unitOfWork) { }
    }
}

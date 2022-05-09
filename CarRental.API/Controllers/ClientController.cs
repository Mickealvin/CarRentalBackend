using CarRental.API.Concrete;
using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseController<Client>
    {
        public ClientController(IUnitOfWork unitOfWork): base(unitOfWork) { }
    }
}

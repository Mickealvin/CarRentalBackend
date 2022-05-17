using CarRental.Domain.Entities;
using CarRental.Domain.Interfaces;
using CarRental.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Repositories
{
    public class AuthRepository : BaseRepository<User>, IAuthRepository
    {
        public AuthRepository(CarRentalContext dbContext) : base(dbContext)
        {
        }

        public Task<User> Login(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}

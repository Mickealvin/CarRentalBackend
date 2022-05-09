using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.API.Abstract
{
    public interface IBaseController<T>
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetById(int Id);
        Task<IActionResult> Create(T _object);
        Task<IActionResult> Update(T _object);
        Task<IActionResult> Delete(int Id);
    }
}

using CarRental.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CarRental.API.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception.GetType().Name == "DbUpdateException" ? context.Exception.InnerException : context.Exception;

            var statusCode = HttpStatusCode.InternalServerError;
            var message = "Error inesperado";
            if (exception.Message.Contains("cannot insert duplicate key row in object", StringComparison.InvariantCultureIgnoreCase))
            {
                statusCode = HttpStatusCode.BadRequest;
                message = "No se pueden insertar datos duplicados";
            }
            var response = new ResponseDto<bool>(false)
            {
                ErrorMessage = message,
                Success = false,
            };
            if(statusCode == HttpStatusCode.BadRequest)
            {
                context.Result = new BadRequestObjectResult(response);
            } else
            {
                var objectResult = new ObjectResult(response);
                objectResult.StatusCode = (int)statusCode;
                context.Result = objectResult;
            }

            context.HttpContext.Response.StatusCode = (int)statusCode;
            context.ExceptionHandled = true;
        }
    }
}

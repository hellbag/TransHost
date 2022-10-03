using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using TransHostApi.Contracts;
using TransHostApi.Model.Exceptions;
using TransHostApi.Services;

namespace TransHostApi
{
    /// <summary>
    /// Глобальная обработка исключений.
    /// </summary>
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ILogger<ExceptionHandlerMiddleware> _logger,IJsonSerializer json)
        {
            context.Response.ContentType = "application/json";
            ErrorResponse err = null;
            try
            {
                await _next.Invoke(context);
            }
            catch (ExternalServerException ex)
            {
                context.Response.StatusCode = 400;
                err = new ErrorResponse("Ошибка cteleport.com");
            }
            catch (IataValidException ex)
            {
                context.Response.StatusCode = 400;
                err = new ErrorResponse("Неверный код аэропорта.");

            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                err = new ErrorResponse("Внутренняя ошибка сервиса.");
            }
            finally
            {
                if (err != null)
                {
                    var result = await json.ToJsonString(err);
                    await context.Response.WriteAsync(result);
                }
            }
        }

        
    }
}
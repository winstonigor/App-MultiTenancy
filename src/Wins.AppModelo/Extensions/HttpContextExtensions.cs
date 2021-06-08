using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// 
/// </summary>
namespace Wins.AppModelo.Extensions
{
    public static class HttpContextExtensions
    {
        // dominio/tenant-1/produto
        public static string GetTenantId(this HttpContext httpContext)
        {
            var tenant = httpContext.Request.Path.Value.Split('/', System.StringSplitOptions.RemoveEmptyEntries)[0];
            return tenant;
        }
    }
}

using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Middleware
{
    public static class AppConfiguration
    {
        public static void Cors(this IApplicationBuilder app)
        {
            app.UseCors(
                options => options.AllowAnyOrigin()
            );
        }

        public static IApplicationBuilder ExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}

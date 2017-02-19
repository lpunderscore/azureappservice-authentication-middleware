using Microsoft.AspNetCore.Builder;
using System;

namespace Middleware.Authentication.AppService
{
    public static class AzureAppServiceAuthenticationAppBuilderExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseAzureAppServiceAuthentication(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<AuzreAppServiceAuthenticationMiddleware>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseAzureAppServiceAuthentication(this IApplicationBuilder app, AzureAppServiceAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            return app.UseMiddleware<AuzreAppServiceAuthenticationMiddleware>(options);
        }
    }
}

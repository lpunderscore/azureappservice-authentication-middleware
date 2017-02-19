using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;

namespace Middleware.Authentication.AppService
{
    public class AuzreAppServiceAuthenticationMiddleware : AuthenticationMiddleware<AzureAppServiceAuthenticationOptions>
    {
        public AuzreAppServiceAuthenticationMiddleware(RequestDelegate next, 
            IOptions<AzureAppServiceAuthenticationOptions> options, 
            ILoggerFactory loggerFactory, 
            UrlEncoder encoder) : base(next, options, loggerFactory, encoder)
        {

        }

        protected override AuthenticationHandler<AzureAppServiceAuthenticationOptions> CreateHandler()
        {
            return new AzureAppServiceAuthenticationHandler();
        }
    }
}

using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authentication;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace Aldente.Services
{
    public class TenantServices : ITenantService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public TenantServices(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }
        public string getTenant()
        {
            var httpContext = httpContextAccessor.HttpContext;

            if (httpContext is null)return string.Empty;

            var authTicket = DecryptAuthCookie(httpContext);

            if (authTicket is null) return string.Empty;

            var claimTenant = authTicket.Principal.Claims.FirstOrDefault(x => x.Type == Constan.ClaimTenantId);

            if (claimTenant is null) return string.Empty;

            return claimTenant.Value;
        }
        private static AuthenticationTicket? DecryptAuthCookie(HttpContext httpContext)
        {
            var opt = httpContext.RequestServices.GetRequiredService<IOptionsMonitor<CookieAuthenticationOptions>>().Get("Identity.Application");
            var cookie = opt.CookieManager.GetRequestCookie(httpContext, opt.Cookie.Name!);

            return opt.TicketDataFormat.Unprotect(cookie);
        }

    }
}

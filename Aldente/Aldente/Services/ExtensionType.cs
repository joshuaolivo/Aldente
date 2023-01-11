using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aldente.Services
{
    public static class ExtensionType
    {
        public static bool NoValidateTenant(this Type t)
        {
            var boleans = new List<bool>()
            {
                    t.IsAssignableFrom(typeof(IdentityRole)),
                    t.IsAssignableFrom(typeof(IdentityRoleClaim<string>)),
                    t.IsAssignableFrom(typeof(IdentityUser)),
                    t.IsAssignableFrom(typeof(IdentityUserLogin<string>)),
                    t.IsAssignableFrom(typeof(IdentityUserRole<string>)),
                    t.IsAssignableFrom(typeof(IdentityUserToken<string>)),
                    t.IsAssignableFrom(typeof(IdentityUserClaim<string>)),
                    typeof(ITenantEntity).IsAssignableFrom(t)
            };

            return boleans.Aggregate((b1, b2) => b1 || b2);
        }
    }
}

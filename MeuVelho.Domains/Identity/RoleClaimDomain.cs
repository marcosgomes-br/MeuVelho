using System;
using Microsoft.AspNetCore.Identity;

namespace MeuVelho.Domains
{
    public class RoleClaimDomain : IdentityRoleClaim<Guid>
    {
        public RoleDomain Role { get; } = new RoleDomain();
    }
}
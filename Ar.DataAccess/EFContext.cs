using Ar.DataAccess.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ar.DataAccess
{
    public class EFContext : IdentityDbContext<User>
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
    }
}

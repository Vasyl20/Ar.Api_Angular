using Ar.DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AR.Domain.Interfaces
{
    public interface IJWTTokenService
    {
        string CreateToken(User user);
    }
}

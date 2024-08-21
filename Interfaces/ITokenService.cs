using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiracleApi.Models;

namespace MiracleApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
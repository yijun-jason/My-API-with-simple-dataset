using JWTAuthentication_TokenBarer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication_TokenBarer.Services
{
    public interface IAuthenticateService
    {
        Skator Authenticate(String UserName, String Password);
    }
}

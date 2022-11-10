using ResultTool.Entities;
using ResultTool.ResultTool;
using ResultTool.ResultTool.AuthResult;
using ResultTool.ResultTool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.Services
{
    public class AuthService
    {
        public IAuthResult Register(string name, string userName, string password)
        {
            //Business operation

            if (false) return new AuthResult(false);

            return new AuthResult(true,"Register success");
        }

        public IAuthResult Login(string userName, string password)
        {
            //Business operation

            if (false) return new AuthResult(false);

            return new AuthResult(true, "Login success")
            {
                Token = "Access Token"
            };
        }
    }
}

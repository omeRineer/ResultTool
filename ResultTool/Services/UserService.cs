using ResultTool.Entities;
using ResultTool.ResultTool;
using ResultTool.ResultTool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.Services
{
    public class UserService
    {
        public IResult CreateUser(User user)
        {
            //Business operation

            if (false) return new ErrorResult("User added is failed");
            return new SuccessResult("User is added");
        }

        public IResult DeleteUser(int id)
        {
            //Business operation

            if (false) return new ErrorResult("User deleted is failed");
            return new SuccessResult("User is deleted");
        }
    }
}

using ResultTool.Entities;
using ResultTool.Services;
using System;

namespace ResultTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userService=new UserService();
            User user = new User { Id=1, FirstName = "Software", LastName = "Developer", Phone = "01324567845" };
            var result = userService.CreateUser(user);
            Console.WriteLine(result.Message);
        }
    }
}

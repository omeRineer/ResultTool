using ResultTool.Entities;
using ResultTool.Services;
using System;

namespace ResultTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userService = new AuthService();
            var result = userService.Register("Ömer", "omer", "234");
            Console.WriteLine(result.Message);
        }
    }
}

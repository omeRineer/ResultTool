using System.Collections.Generic;
using ResultTool.ResultTool.Common;
using ResultTool.ResultTool.Model.Errors;

namespace ResultTool.ResultTool.AuthResult
{
    public class AuthResult<TError> : Result, IAuthResult<TError>
    {
        public AuthResult(bool success) : base(success)
        {

        }
        public AuthResult(bool success, string message) : base(success, message)
        {

        }
        public AuthResult(bool success, string message, List<TError> errors) : base(success, message)
        {
            Errors = errors;
        }

        public List<TError> Errors { get; set; }
        public string Token { get; set; }
    }

    public class AuthResult : AuthResult<Error>, IAuthResult
    {
        public AuthResult(bool success) : base(success)
        {

        }
        public AuthResult(bool success, string message) : base(success, message)
        {

        }
        public AuthResult(bool success, string message, List<Error> errors) : base(success, message, errors)
        {

        }
    }
}

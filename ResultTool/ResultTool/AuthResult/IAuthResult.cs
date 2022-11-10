using ResultTool.ResultTool.Common;
using ResultTool.ResultTool.Model.Errors;

namespace ResultTool.ResultTool.AuthResult
{
    public interface IAuthResult<TError> : IErrorResult<TError>, ISuccessResult
    {
        public string Token { get; set; }
    }

    public interface IAuthResult : IAuthResult<Error>
    {

    }
}

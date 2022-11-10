namespace ResultTool.ResultTool.Common
{
    public interface IAuthResult<TError> : IErrorResult<TError>, ISuccessResult
    {
        public string Token { get; set; }
    }

    public interface IAuthResult : IAuthResult<Error>
    {

    }
}

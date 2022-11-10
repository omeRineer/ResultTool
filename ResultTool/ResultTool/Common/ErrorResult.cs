using ResultTool.ResultTool.Model.Errors;
using System.Collections.Generic;

namespace ResultTool.ResultTool.Common
{
    public class ErrorResult : Result, IErrorResult<Error>
    {
        public ErrorResult() : base(false)
        {

        }
        public ErrorResult(string message) : base(false, message)
        {
            Errors = default;
        }

        public List<Error> Errors { get; set; }
    }
}

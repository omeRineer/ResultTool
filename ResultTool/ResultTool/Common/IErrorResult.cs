using System.Collections.Generic;

namespace ResultTool.ResultTool.Common
{
    public interface IErrorResult<TError> : IResult
    {
        public List<TError> Errors { get; set; }
    }
}

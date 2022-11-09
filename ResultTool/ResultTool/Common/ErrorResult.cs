namespace ResultTool.ResultTool.Common
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(false, message)
        {

        }
    }
}

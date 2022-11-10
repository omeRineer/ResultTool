using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public class SuccessResult : Result, ISuccessResult
    {
        public SuccessResult() : base(true)
        {

        }
        public SuccessResult(string message) : base(true, message)
        {

        }
    }
}

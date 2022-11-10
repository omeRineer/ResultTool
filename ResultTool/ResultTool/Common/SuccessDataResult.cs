using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public class SuccessDataResult<TData> : DataResult<TData>
    {
        public SuccessDataResult(TData data, string message) : base(data, true, message)
        {

        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult(TData data) : base(data, true)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}

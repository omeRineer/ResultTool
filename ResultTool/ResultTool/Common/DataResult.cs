using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        public TData Data { get; set; }

        public DataResult(TData data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(TData data, bool success) : base(success)
        {

        }
    }
}

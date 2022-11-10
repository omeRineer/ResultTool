using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}

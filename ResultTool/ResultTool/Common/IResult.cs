using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public interface IResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}

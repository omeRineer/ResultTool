using ResultTool.ResultTool.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.Services
{
    public class ProductService
    {
        public IResult CreateProduct()
        {
            //Business operations

            if(false) return new ErrorResult("Product added is failed");

            return new SuccessResult("Product added is success");
        }
    }
}

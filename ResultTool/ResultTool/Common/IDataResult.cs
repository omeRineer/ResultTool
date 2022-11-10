﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultTool.ResultTool.Common
{
    public interface IDataResult<TData> : IResult
    {
        public TData Data { get; set; }
    }
}
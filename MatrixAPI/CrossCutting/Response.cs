﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatrixAPI.CrossCutting
{
    public class Response
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public string Result { get; set; }
    }
}
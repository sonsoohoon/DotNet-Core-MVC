﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Services
{
    public interface IDateTime
    {
        DateTime Now { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cqrs.Common.Queries.Pagination
{
    public interface IPage
    {
        int Number { get; }

        int Size { get; }

        int Offset { get; }
    }
}

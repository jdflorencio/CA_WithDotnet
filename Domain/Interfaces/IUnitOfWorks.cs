﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces
{
    internal interface IUnitOfWorks
    {
        Task Commit(CancellationToken cancellationToken);
    }
}

﻿using Dorixona.ConsoleApp.Interfaces.Common;
using Dorixona.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.RepositoryInterfaces
{
    public interface IOrderRepository :
        ICreatable<Order>, IReadable<Order>, IUpdateable<Order>, IDeleteable<Order>
    {
    }
}

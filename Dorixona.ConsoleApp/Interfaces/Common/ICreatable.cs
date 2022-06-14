using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.Common
{
    public interface ICreatable<T>
    {
        public Task CreateAsync(T obj);
    }
}

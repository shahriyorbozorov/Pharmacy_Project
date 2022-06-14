using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.Common
{
    public interface IUpdateable<T>
    {
        public Task UpdateAsync(int id, T obj);
    }
}

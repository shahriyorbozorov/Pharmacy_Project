using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.Common
{
    public interface IDeleteable<T>
    {
        public Task DeleteAsync(int id);
    }
}

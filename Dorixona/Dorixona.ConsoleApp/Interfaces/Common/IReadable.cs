using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.Common
{
    public interface IReadable<T>
    {
        public Task<IEnumerable<T>> GetAllAsync();

        public Task<T> GetAsync(int Id);
    }
}

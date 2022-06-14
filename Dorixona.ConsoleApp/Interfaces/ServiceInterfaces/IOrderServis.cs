using Dorixona.ConsoleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Interfaces.ServiceInterfaces
{
    public interface IOrderServis
    {
       Task<IEnumerable<OrderViewModel>> GetSumAsync();
    }
}

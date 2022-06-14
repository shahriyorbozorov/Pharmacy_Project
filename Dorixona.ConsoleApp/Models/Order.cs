using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int RecipeID { get; set; }
        public int MedicineId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double MedicinePrice { get; set; }
        public int Count { get; set; }
        public double Summ { get; set; }



    }
}

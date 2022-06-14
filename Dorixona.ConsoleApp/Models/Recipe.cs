using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public int MedicineId { get; set; }
        public string DoctorName { get; set; }
        public int Count { get; set; }

    }
}

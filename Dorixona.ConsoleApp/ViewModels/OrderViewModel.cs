using Dorixona.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.ViewModels
{
    public class OrderViewModel
    {
        public int RecipeID { get; set; }
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public DrugType DrugType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double MedicinePrice { get; set; }
        public int Count { get; set; }
        public double Summ { get; set; }
    }
}

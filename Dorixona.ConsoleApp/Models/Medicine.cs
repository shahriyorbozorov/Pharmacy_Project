using Dorixona.ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Models
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public DrugType DrugType { get; set; }
        public DateTime MedicineDate { get; set; }    // ishlab chiqarilgan san
        public string ShelfLife { get; set; }   //  saqlash muddati  masalan 5 oy
        public int MedicineCount { get; set; }
        public double MedicinePrice { get; set; }   // bitta dorining narxi


    }
}

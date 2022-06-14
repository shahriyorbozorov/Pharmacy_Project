using ConsoleTables;
using Dorixona.ConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Pages
{
    public class OrderPage
    {

        public static async Task RunSummAsync()
        {
            OrderServis orderServis = new OrderServis();
            var orderViewModels = await orderServis.GetSumAsync();
            ConsoleTable consoleTable =
                new ConsoleTable(" RecipeId ", " MedicineName ",
                " Medicine Type ", " Medicine Price ", " Count ", " SUMM ", "Registration Date");

            foreach (var order in orderViewModels)
            {
                consoleTable.AddRow(order.RecipeID, order.MedicineName, order.DrugType, order.MedicinePrice, order.Count,
                    order.Summ, order.RegistrationDate);
            }

            consoleTable.Write();
        }
     }

}

using Dorixona.ConsoleApp.Interfaces.RepositoryInterfaces;
using Dorixona.ConsoleApp.Repositories;
using Dorixona.ConsoleApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.ConsoleApp.Interfaces.ServiceInterfaces;
using Dorixona.ConsoleApp.Interfaces.ServiceInterfaces;

namespace Dorixona.ConsoleApp.Services
{
    public class OrderServis : IOrderServis
    {
        private readonly IMedicineRepository medicineRepository;
        private readonly IRecipeRepository recipeRepository;
        private readonly IOrderRepository orderRepository;


        public OrderServis()
        {
            orderRepository = new OrderRepository();
            medicineRepository = new MedicineRepository();
            recipeRepository = new RecipeRepository();
        }

        public async Task<IEnumerable<OrderViewModel>> GetSumAsync()
        {
            var recipes = await recipeRepository.GetAllAsync();

            List<OrderViewModel> list = new List<OrderViewModel>();

            foreach (var recipe in recipes)
            {
                OrderViewModel orderViewModel = new OrderViewModel();
                orderViewModel.RecipeID = recipe.RecipeID;

                var drug = await medicineRepository.GetAsync(recipe.RecipeID);
                orderViewModel.MedicineId = drug.MedicineId;
                orderViewModel.MedicineName = drug.MedicineName;
                orderViewModel.DrugType = drug.DrugType;
                orderViewModel.RegistrationDate = drug.MedicineDate;
                orderViewModel.MedicinePrice = drug.MedicinePrice;
                orderViewModel.Count = recipe.Count;
                var summ = drug.MedicinePrice * recipe.Count;
                orderViewModel.Summ = summ;

                list.Add(orderViewModel);
            }
            return list;



        }


    }
}

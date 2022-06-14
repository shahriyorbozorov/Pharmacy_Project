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
            var orders = await orderRepository.GetAllAsync();

            List<OrderViewModel> list = new List<OrderViewModel>();

            foreach (var order in orders)
            {
                OrderViewModel orderViewModel = new OrderViewModel();
                orderViewModel.MedicineId = order.MedicineId;
                var recip = await recipeRepository.GetAsync(order.MedicineId);
                orderViewModel.Summ = order.MedicinePrice * order.Count;
                var drug = await medicineRepository.GetAsync(order.MedicineId);
                orderViewModel.MedicineName = drug.MedicineName;
                orderViewModel.DrugType = drug.DrugType;
                orderViewModel.MedicinePrice = order.MedicinePrice;
                orderViewModel.RegistrationDate = order.RegistrationDate;

                list.Add(orderViewModel);
            }
            return list;
        }

    }
}

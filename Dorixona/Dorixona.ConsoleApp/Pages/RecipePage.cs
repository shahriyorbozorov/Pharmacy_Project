using Dorixona.ConsoleApp.Interfaces.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.ConsoleApp.Repositories;
using Dorixona.ConsoleApp.Models;
using ConsoleTables;

namespace Dorixona.ConsoleApp.Pages
{
    public class RecipePage
    {
        public static async Task RunCreatAsync()
        {
            await MedicinePage.RunGetAllAsync();
            IRecipeRepository recipeRepository = new RecipeRepository();

            Console.Write("Enter recipe ID > ");
            int recipeId = int.Parse(Console.ReadLine());

            Console.Write("Enter medicine ID > ");
            int drugId = int.Parse(Console.ReadLine());

            Console.Write("Enter doctor name > ");
            string doctorname = Console.ReadLine();

            Console.Write("Enter count > ");
            int count = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe();
            {
               recipe.RecipeID = recipeId;
               recipe.MedicineId = drugId;
               recipe.Count = count;
               recipe.DoctorName = doctorname;
            }
            await recipeRepository.CreateAsync(recipe);
        }
        public static async Task RunGetAsync()
        {
            IRecipeRepository recipeRepository1 = new RecipeRepository();

            Console.Write("Enter recipe ID > ");
            int _id = int.Parse(Console.ReadLine());

            ConsoleTable recipetable = new ConsoleTable(" RecipeId ", " DrugId ", " Count ", " Doctor ");

            var recipe = await recipeRepository1.GetAsync(_id);

            recipetable.AddRow(recipe.RecipeID, recipe.MedicineId, recipe.Count, recipe.DoctorName);

            recipetable.Write();
        }
        public static async Task RunGetAllAsync()
        {
            IRecipeRepository recipeRepository2 = new RecipeRepository();
           
            ConsoleTable recipetable = new ConsoleTable(" RecipeId ", " DrugId ", " Count ", " Doctor ");

            var recipes = await recipeRepository2.GetAllAsync();

            foreach (var recipe in recipes)
            {
                recipetable.AddRow(recipe.RecipeID, recipe.MedicineId, recipe.Count, recipe.DoctorName);
            }
            recipetable.Write();
        }
        public static async Task RunDeleteAsync()
        {
            IRecipeRepository recipeRepository3 = new RecipeRepository();

            Console.Write("Enter recipe ID > ");
            int _id = int.Parse(Console.ReadLine());

            await recipeRepository3.DeleteAsync(_id);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{_id} successfully deleted !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static async Task RunUpdateAsync()
        {

            IRecipeRepository recipeRepository4 = new RecipeRepository();
            
            Console.Write("Enter the ID to be updated > ");
            int _Id = int.Parse(Console.ReadLine());

            Console.Write("Enter recipe ID > ");
            int recipeId = int.Parse(Console.ReadLine());

            Console.Write("Enter medicine ID > ");
            int drugId = int.Parse(Console.ReadLine());

            Console.Write("Enter doctor name > ");
            string doctorname = Console.ReadLine();

            Console.Write("Enter count > ");
            int count = int.Parse(Console.ReadLine());

            Recipe recipe = new Recipe();
            {
                recipe.RecipeID = recipeId;
                recipe.MedicineId = drugId;
                recipe.Count = count;
                recipe.DoctorName = doctorname;
            }
            await recipeRepository4.UpdateAsync(_Id, recipe);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dorixona.ConsoleApp.Interfaces.RepositoryInterfaces;
using Dorixona.ConsoleApp.Models;
using Dorixona.ConsoleApp.Constants;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Dorixona.ConsoleApp.Repositories
{
    internal class RecipeRepository : IRecipeRepository
    {
        private const string _dbPath = DbConstants.RECIPE_DB_PATH;
        public async Task CreateAsync(Recipe obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);

            if (recipeList == null) recipeList = new List<Recipe>();
            recipeList.Add(obj);

            var newjson = JsonConvert.SerializeObject(recipeList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task DeleteAsync(int id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);

            var deletedIndex = recipeList.TakeWhile(x => x.RecipeID != id).Count();

            recipeList.RemoveAt(deletedIndex);

            var newjson = JsonConvert.SerializeObject(recipeList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }

        public async Task<IEnumerable<Recipe>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);

            return recipeList;
        }

        public async Task<Recipe> GetAsync(int Id)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);

            return recipeList.FirstOrDefault(x => x.RecipeID == Id);
        }

        public async Task UpdateAsync(int id, Recipe obj)
        {
            var json = await File.ReadAllTextAsync(_dbPath);

            var recipeList = JsonConvert.DeserializeObject<List<Recipe>>(json);

            var updatedIndex = recipeList.TakeWhile(x => x.RecipeID != id).Count();

            recipeList[updatedIndex] = obj;

            var newjson = JsonConvert.SerializeObject(recipeList);

            await File.WriteAllTextAsync(_dbPath, newjson);
        }
    }

}

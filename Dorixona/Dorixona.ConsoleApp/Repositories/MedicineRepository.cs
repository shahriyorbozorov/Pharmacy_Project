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
    public class MedicineRepository : IMedicineRepository
    {
        private const string dbPath = DbConstants.MEDICINE_DB_PATH;
        public async Task CreateAsync(Medicine obj)
        {
           var json = await File.ReadAllTextAsync(dbPath);
           var medicineList = JsonConvert.DeserializeObject<List<Medicine>>(json);

            if (medicineList == null) medicineList = new List<Medicine>();
            medicineList.Add(obj);

            var newjson = JsonConvert.SerializeObject(medicineList);

            await File.WriteAllTextAsync(dbPath, newjson);
        }

        public async Task DeleteAsync(int id)
        {
            var json = await File.ReadAllTextAsync(dbPath);

            var medicineList = JsonConvert.DeserializeObject<List<Medicine>>(json);

            var deletedIndex = medicineList.TakeWhile(x => x.MedicineId != id).Count();

            medicineList.RemoveAt(deletedIndex);

            var newjson = JsonConvert.SerializeObject(medicineList);

            await File.WriteAllTextAsync(dbPath, newjson);
        }

        public async Task<IEnumerable<Medicine>> GetAllAsync()
        {
            var json = await File.ReadAllTextAsync(dbPath);

            var medicineList = JsonConvert.DeserializeObject<List<Medicine>>(json);

            return medicineList;
        }

        public async Task<Medicine> GetAsync(int Id)
        {
            var json = await File.ReadAllTextAsync(dbPath);

            var medicineList = JsonConvert.DeserializeObject<List<Medicine>>(json);

            return medicineList.FirstOrDefault(x => x.MedicineId == Id);
        }

        public async Task UpdateAsync(int id, Medicine obj)
        {
            var json = await File.ReadAllTextAsync(dbPath);

            var medicineList = JsonConvert.DeserializeObject<List<Medicine>>(json);

            var updatedIndex = medicineList.TakeWhile(x => x.MedicineId != id).Count();

            medicineList[updatedIndex] = obj;

            var newjson = JsonConvert.SerializeObject(medicineList);

            await File.WriteAllTextAsync(dbPath, newjson);
        }
    }
}

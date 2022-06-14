using Dorixona.ConsoleApp.Enums;
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
    public class MedicinePage
    {
        public static async Task RunCreatAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository = new MedicineRepository();
            
            Console.Write("Enter medicine ID > ");
            int Id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter medicine name > ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Choose medicine type > ");
            Console.WriteLine("1. Pill");
            Console.WriteLine("2. Syrup");
            Console.WriteLine("3. Capsule");
            Console.WriteLine("4. Solution");
            Console.WriteLine("5. Maz");
            Console.WriteLine("6. Liquid");
            DrugType drugType = (DrugType)(int.Parse(Console.ReadLine()));
            Console.Clear();
            Console.Write("Enter shelf life > ");
            string shelflife = Console.ReadLine();

            Console.Write("Enter count > ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Enter price > ");
            int quantity = int.Parse(Console.ReadLine());
            
            Medicine medicine = new Medicine();
            {
                medicine.MedicineId = Id;
                medicine.MedicineName = name;
                medicine.DrugType = drugType;
                medicine.MedicineDate = DateTime.Now;
                medicine.ShelfLife = shelflife;
                medicine.MedicineCount = count;
                medicine.MedicinePrice = quantity;
            }
            await medicineRepository.CreateAsync(medicine);
        }
        public static async Task RunGetAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository1 = new MedicineRepository();

            Console.Write("Enter medicine ID > ");
            int _id = int.Parse(Console.ReadLine());

            ConsoleTable drugtable = 
                new ConsoleTable(" Id ", " Name ", " Type ", " Price ", "Count" , " Shelf life ", " Production day ");
            
            var drug = await medicineRepository1.GetAsync(_id);
            
            drugtable.AddRow(drug.MedicineId, drug.MedicineName, drug.DrugType, drug.MedicinePrice,drug.MedicineCount, drug.ShelfLife,drug.MedicineDate);
            
            drugtable.Write();
        }
        public static async Task RunGetAllAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository2 = new MedicineRepository();
            ConsoleTable drugtable =
                new ConsoleTable(" Id ", " Name ", " Type ", " Price ", "Count", " Shelf life ", " Production day ");

            var drugs = await medicineRepository2.GetAllAsync();

            foreach (var drug in drugs)
            { 
                 drugtable.AddRow(drug.MedicineId, drug.MedicineName, 
                     drug.DrugType, drug.MedicinePrice, drug.MedicineCount, drug.ShelfLife, drug.MedicineDate);
            }
            drugtable.Write();
        }
        public static async Task RunDeleteAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository3 = new MedicineRepository();
            Console.Write("Enter medicine ID > ");
            int _id = int.Parse(Console.ReadLine());

            await medicineRepository3.DeleteAsync(_id);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Beep(500, 500);
            Console.WriteLine($"{_id} successfully deleted !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static async Task RunGetOrdersAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository2 = new MedicineRepository();
            ConsoleTable drugtable =
                new ConsoleTable(" Id ", " Name ", " Type ", " Price ", "Count", " Shelf life ", " Production day ");

            var drugs = await medicineRepository2.GetAllAsync();

            foreach (var drug in drugs)
            {
                drugtable.AddRow(drug.MedicineId, drug.MedicineName,
                    drug.DrugType, drug.MedicinePrice, drug.MedicineCount, drug.ShelfLife, drug.MedicineDate);
            }
            drugtable.Write();
        }
        public static async Task RunUpdateAsync()
        {
            Console.Clear();
            IMedicineRepository medicineRepository4 = new MedicineRepository();
           
            Console.Write("Enter medicine ID > ");
            int _id = int.Parse(Console.ReadLine());

            Console.Write("Enter medicine ID > ");
            int Id = int.Parse(Console.ReadLine());
            
            Console.Write("Enter medicine name > ");
            string name = Console.ReadLine();
            
            Console.Write("Choose medicine type > ");
            Console.WriteLine("1. Pill");
            Console.WriteLine("2. Syrup");
            Console.WriteLine("3. Capsule");
            Console.WriteLine("4. Solution");
            Console.WriteLine("5. Maz");
            Console.WriteLine("6. Liquid");
            DrugType drugType = (DrugType)(int.Parse(Console.ReadLine()));

            Console.Write("Enter shelf life > ");
            string shelflife = Console.ReadLine();

            Console.Write("Enter count > ");
            int count = int.Parse(Console.ReadLine());

            Console.Write("Enter price > ");
            int quantity = int.Parse(Console.ReadLine());
            
            Medicine medicine = new Medicine();
            {
                medicine.MedicineId = Id;
                medicine.MedicineName = name;
                medicine.DrugType = drugType;
                medicine.MedicineDate = DateTime.Now;
                medicine.ShelfLife = shelflife;
                medicine.MedicineCount = count;
                medicine.MedicinePrice = quantity;
            }
            await medicineRepository4.UpdateAsync(_id, medicine);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{_id} successfully updeted !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}

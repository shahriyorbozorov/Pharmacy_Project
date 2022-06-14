using Dorixona.ConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Pages
{
    public class MainMenuPage
    {
        public static async Task RunAsync()
        {
        label:
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("        >>>>>        Welcome to our program !       <<<<<\n ");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n====== Choose who are you ======\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("         1. Pharmacist\n" +
                    "          2. Customer\n");
                Console.Write("> ");

                Console.ForegroundColor = ConsoleColor.Green;
                int input = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;

                if (input == 1)
                {
                        while (true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("\n         ----***  Welcome boss ***---- \n");
                            Console.ForegroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("1. Create medicine");
                            Console.WriteLine("2. Get medicine");
                            Console.WriteLine("3. Gel all medicines");
                            Console.WriteLine("4. Delet medicine");
                            Console.WriteLine("5. Update medicine");
                            Console.WriteLine("6. Get orders");
                            Console.WriteLine("7. Back\n");
                            Console.Write("> ");
                        Console.ForegroundColor = ConsoleColor.Green;


                        int input1 = int.Parse(Console.ReadLine());
                        if (input1 == 1) await MedicinePage.RunCreatAsync();
                        else if (input1 == 2) await MedicinePage.RunGetAsync();
                        else if (input1 == 3) await MedicinePage.RunGetAllAsync();
                        else if (input1 == 4) await MedicinePage.RunDeleteAsync();
                        else if (input1 == 5) await MedicinePage.RunUpdateAsync();
                        else if (input1 == 6) await OrderPage.RunSummAsync();
                        else if (input1 == 7) goto label;
                        }

                    }
                else if (input == 2)
                {
                    Console.Clear();
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("     \n----- # WELCOME #------ !\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        label1:
                        Console.WriteLine("1. Create recipe");
                        Console.WriteLine("2. Get recipe");
                        Console.WriteLine("3. Gel all recipes");
                        Console.WriteLine("4. Delet resipes");
                        Console.WriteLine("5. Update medicine");
                        Console.WriteLine("6. Get summ");
                        Console.WriteLine("7. Back\n");
                        Console.Write("> ");

                        int input2 = int.Parse(Console.ReadLine());
                        if (input2 == 1) await RecipePage.RunCreatAsync();
                        else if (input2 == 2) await RecipePage.RunGetAsync();
                        else if (input2 == 3) await RecipePage.RunGetAllAsync();
                        else if (input2 == 4) await RecipePage.RunDeleteAsync();
                        else if (input2 == 5) await RecipePage.RunUpdateAsync();
                        else if (input2 == 6) await OrderPage.RunSummAsync();
                        else if (input2 == 7) goto label;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nError selection !\n");
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }

        }
    }
}

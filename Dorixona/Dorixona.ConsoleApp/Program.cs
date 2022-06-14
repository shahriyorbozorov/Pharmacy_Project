using Dorixona.ConsoleApp.Constants;
using Dorixona.ConsoleApp.Enums;
using Dorixona.ConsoleApp.Interfaces.RepositoryInterfaces;
using Dorixona.ConsoleApp.Models;
using Dorixona.ConsoleApp.Pages;
using Dorixona.ConsoleApp.Repositories;
using Dorixona.ConsoleApp.Services;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp
{
    internal class Program
    {
        //  login = wifi
       //   parol = fiwi
        static async Task Main(string[] args)
        {
            //
            /*Hesh.Run();*/
        label:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter your login: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string login = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter your password: ");
            Console.ForegroundColor = ConsoleColor.Black;
            string password = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            
            var json = await File.ReadAllTextAsync(DbConstants.HESHLAR_DB_PATH);
            LogPass logPass = JsonConvert.DeserializeObject<LogPass>(json);
            if (logPass.Login == Hesh.GetHashVersion(login) && logPass.Password == Hesh.GetHashVersion(password))
            {
               
                await MainMenuPage.RunAsync();
            }
            else
            {
                Console.Beep(1000, 400);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong login or password.");
                Console.ForegroundColor = ConsoleColor.White;
                goto label;
            }
            
        }
    }
}



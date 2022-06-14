using Dorixona.ConsoleApp.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Services
{
    public class LogPass_
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
    public static class Hesh
    {
        public static void Run()
        {
            /*LogPass logPass = new LogPass();
            logPass.Login = GetHashVersion("wifi");
            logPass.Password = GetHashVersion("fiwi");
            var json = JsonConvert.SerializeObject(logPass);
            File.WriteAllText(DbConstants.HESHLAR_DB_PATH, json);*/

        }
        public static string GetHashVersion(this string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dorixona.ConsoleApp.Constants
{
    internal class DbConstants
    {
        public const string DB_DIRECTORY_PATH = "Database";

        public const string MEDICINE_DB_PATH = DB_DIRECTORY_PATH + "//" + "medicines.json";

        public const string RECIPE_DB_PATH = DB_DIRECTORY_PATH + "//" + "recipes.json";

        public const string ORDER_DB_PATH = DB_DIRECTORY_PATH + "//" + "orders.json";

        public const string HESHLAR_DB_PATH = DB_DIRECTORY_PATH + "//" + "heshkod.json";
    }
}

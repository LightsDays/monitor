using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor2
{
    internal class Settings
    {
        static readonly string host = HOST_NAME;
        static readonly string user = USER_NAME;
        static readonly string password = BASE_PASWD;
        static readonly string dbname = "kis";
        public static string connString = String.Format("Host = {0}; Username = {1}; Password = {2}; Database={3}", host, user, password, dbname);
        public static string[] sqlPath = { @".\sql\sqlPAD.txt", @".\sql\sqlHospWithoutII.txt", @".\sql\sqlHospWithoutLI.txt", @".\sql\sqlHospWithoutLP.txt", @".\sql\sqlCheckLP.txt" };
        public static string[] sqlPathcount = { @".\sql\sqlPADcount.txt", @".\sql\sqlHospWithoutIIcount.txt", @".\sql\sqlHospWithoutLIcount.txt", @".\sql\sqlHospWithoutLPcount.txt" };
    }
}

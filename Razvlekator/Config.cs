using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razvlekator
{
    public static class Config
    {
        public static String CONN_STRING { get; set; }

        public static void ApplySettings(String server, String db, String user, String pass) {
            CONN_STRING = "server=" + server + ";user id=" + user + ";password=" + pass + 
                ";persistsecurityinfo=True; database=" + db + "; Charset=utf8;";
        }
    }
}

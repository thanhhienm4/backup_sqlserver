using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Restore.Repositoies
{
    public class BaseDAL
    {
        public static bool Connect()
        {
            try
            {
                Program.connStr =
                   String.Format("Data Source={0} ;Persist Security Info=True;User ID={1}; password={2}",
                                   Program.serverName, Program.username, Program.passWord);

                //if(Program.conn == null)
                Program.conn = new SqlConnection(Program.connStr);

                if (Program.conn.State != ConnectionState.Closed)
                    Program.conn.Close();

                if (Program.conn.State != ConnectionState.Open)
                    Program.conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static void DisConnect()
        {
            if (Program.conn == null)
                return;
            if (Program.conn.State != ConnectionState.Closed)
                Program.conn.Close();
        }
    }
}

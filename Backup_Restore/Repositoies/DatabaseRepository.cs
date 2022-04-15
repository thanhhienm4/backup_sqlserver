using Backup_Restore.Models;
using Backup_Restore.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Backup_Restore.Repositoies
{
    public class DatabaseRepository : BaseDAL
    {
        public List<DatabaseModel> GetDatabases()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = "SELECT name, database_id FROM sys.databases WHERE(database_id > 7) AND(NOT(name LIKE N'distribution'))"
                        + "ORDER BY NAME";
                    List<DatabaseModel> res = conn.Query<DatabaseModel>(command).ToList();
                    return res;
                }

            }catch(Exception ex)
            {
                HandleException.Exec(ex);
                throw (ex);
            }
        }
    }
}

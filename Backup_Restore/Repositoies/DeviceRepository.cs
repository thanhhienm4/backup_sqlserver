using Backup_Restore.Models;
using Backup_Restore.Utils;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Restore.Repositoies
{
    public class DeviceRepository : BaseDAL
    {
        public List<DeviceModel> GetDevices()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = "select * from sys.sysdevices";
                    List<DeviceModel> res = conn.Query<DeviceModel>(command).ToList();
                    return res;
                }

            }
            catch (Exception ex)
            {
                HandleException.Exec(ex);
                throw (ex);
            }
        }
        public int CreateDevice(string type,string name, string file)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = string.Format($" EXEC sp_addumpdevice '{type}', '{name}', '{file}' ;");
                    conn.Execute(command);
                    return 1;
                }

            }
            catch (Exception ex)
            {
                HandleException.Exec(ex);
                return 0;
            }
        }
    }
}

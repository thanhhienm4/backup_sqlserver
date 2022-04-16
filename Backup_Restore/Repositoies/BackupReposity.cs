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
    public class BackupReposity : BaseDAL
    {
        //public int CreateBackup()
        public List<BackupModel> GetBackupByName(string databaseName)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = "SELECT position, name ,backup_start_date , user_name " +
                                    "FROM msdb.dbo.backupset" +
                                    $" WHERE database_name = '{databaseName}' AND type = 'D' AND backup_set_id >= " + 
                                    " (SELECT MAX(backup_set_id) " +
                                     " FROM msdb.dbo.backupset " +
                                        " WHERE media_set_id = " +
                                        " (SELECT MAX(media_set_id) " +
                                            " FROM msdb.dbo.backupset " + 
                                           $" WHERE database_name = '{databaseName}' AND type = 'D') " +
                                        " AND position = 1) " +
                                " ORDER BY backup_start_date DESC ";
                    List<BackupModel> res = conn.Query<BackupModel>(command).ToList();
                    return res;
                }

            }
            catch (Exception ex)
            {
                HandleException.Exec(ex);
                throw (ex);
            }
        }
    }
}

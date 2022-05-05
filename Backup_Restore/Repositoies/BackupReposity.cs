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
        public List<BackupModel> GetBackupByName(string databaseName, string type)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = "SELECT position, name ,backup_start_date , user_name, physical_device_name" +
                                    " FROM msdb.dbo.backupset INNER JOIN msdb.dbo.backupmediafamily  ON msdb.dbo.backupset.media_set_id = msdb.dbo.backupmediafamily.media_set_id" +
                                    $" WHERE database_name = '{databaseName}' AND type = '{type}' AND backup_set_id >= " + 
                                    " (SELECT MAX(backup_set_id) " +
                                     " FROM msdb.dbo.backupset " +
                                        " WHERE media_set_id = " +
                                        " (SELECT MAX(media_set_id) " +
                                            " FROM msdb.dbo.backupset " + 
                                           $" WHERE database_name = '{databaseName}' AND type = '{type}') " +
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
        public int CreateBackup(string nameDatabase, string device, string name, bool init, string strFullPathBackLog)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = $"BACKUP DATABASE {nameDatabase} " +
                                      $" TO {device} ";
                    if (init)
                    {
                        command += " WITH INIT \n";
                        command += $" BACKUP LOG {nameDatabase} TO DISK = '{strFullPathBackLog}' WITH INIT";


                    }    
                       
                   
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
        public int RetoreBackup(string nameDatabase, string device, int pos)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = $"ALTER DATABASE {nameDatabase} SET SINGLE_USER WITH ROLLBACK IMMEDIATE " +
                        $" RESTORE DATABASE {nameDatabase} FROM {device} WITH FILE= {pos} , " + 
                        $" REPLACE ALTER DATABASE  {nameDatabase} SET MULTI_USER ";
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
        public int RetoreBackupToTime(string nameDatabase, string device,  string strFullPathBackLog, DateTime dateTime, int pos)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connStr))
                {
                    string command = 

                        $"ALTER DATABASE {nameDatabase} SET SINGLE_USER WITH ROLLBACK IMMEDIATE ;" +
                        $"BACKUP LOG {nameDatabase} TO DISK = '{strFullPathBackLog}' WITH INIT, NORECOVERY " +
                        "  USE TEMPDB     " +
                        $"RESTORE DATABASE {nameDatabase} FROM {device}  WITH FILE = {pos}, NORECOVERY , " +
                        $"REPLACE " +
                        $"RESTORE DATABASE {nameDatabase} FROM DISK = '{strFullPathBackLog}' WITH STOPAT = '{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}',  RECOVERY ," +
                        $"  REPLACE " +
                        $"ALTER DATABASE  {nameDatabase} SET MULTI_USER ";

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

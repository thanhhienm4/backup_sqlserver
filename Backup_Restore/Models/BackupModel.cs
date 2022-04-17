

using System;

namespace Backup_Restore.Models
{
    public class BackupModel
    {
        public string Database_Name { get; set; }
        public int Position { get; set; }
        public DateTime Backup_Start_Date {get; set;}
        public string User_Name { get; set; }

    }

}
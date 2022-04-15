using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup_Restore.Utils
{
    public class HandleException
    {
        public static void Exec(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}

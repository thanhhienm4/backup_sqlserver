using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;

namespace Backup_Restore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        // public static SqlConnection conn = new SqlConnection();
        //  public static String connstr;
        public static SqlDataAdapter da;
        public static SqlConnection conn = new SqlConnection();

        public static FormMain formMain;
        public static loginForm LoginForm;
        public static string connstr = "";
       // public static SqlConnection connection;     //Connection biến dùng kết nối về db 
        public static SqlDataReader myreader;
        public static String serverName = "";
        public static String username = "";
        public static String passWord = "";
        public static String Db;
        public static String database = "tempdb";
        public static String mlogin = "";
        public static int namBatDau = 2016;
        public static int flagRestore = 0;
        public static String strDefaultPath = "D:/Nam_4_Ki_2/Chuyen_De_CNPM/Backup/Backup_Restore/";
        public static String strDefaultPathNew = "";
        public static String device_type = "Disk";
        [STAThread]
        public static int KetNoi() //null thì lỗi, không null thì chạy
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";User ID=" + Program.username + ";password=" + Program.passWord;
                //Program.conn.ConnectionString = connstr;
                Program.conn = new SqlConnection(Program.connstr);
                Program.conn.Open();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. \nBạn xem lại username và password.\n" + ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static int ExecSqlNonQuery(String str,String connectionString,string errstr)
        {
            conn = new SqlConnection(connectionString);
            SqlCommand sqlcmd = new SqlCommand(str, conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (conn.State == ConnectionState.Closed) conn.Open();
           try
            {
                int loi = sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch(SqlException EX)
            {
                if (EX.Message.Contains("Lỗi chuyển dữ liệu từ varchar sang int"))
                    MessageBox.Show("");
                else
                    MessageBox.Show(errstr +EX.Message);
                conn.Close();
                return 1;
           
            }
        }
        public static SqlDataReader ExecSqlDataReader(String strLenh) 
        {
            SqlDataReader reader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 300; // Đợi lệnh chạy. đơn vị: giây.
         
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                reader = sqlcmd.ExecuteReader();
                return reader;
            }
            catch (SqlException ex)
            {
               
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            LoginForm = new loginForm();
            Application.Run(LoginForm);
        }
    }
}
